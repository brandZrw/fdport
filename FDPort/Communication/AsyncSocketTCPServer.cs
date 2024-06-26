﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace FDPort.Class
{
    public class AsyncSocketTCPServer : IDisposable
    {
        #region Fields
        /// <summary>
        /// 服务器程序允许的最大客户端连接数
        /// </summary>
        private int _maxClient;

        /// <summary>
        /// 当前的连接的客户端数
        /// </summary>
        private int _clientCount;

        /// <summary>
        /// 服务器使用的异步socket
        /// </summary>
        private Socket _serverSock;

        /// <summary>
        /// 客户端会话列表
        /// </summary>
        private Dictionary<EndPoint,AsyncSocketState> _clients;

        private bool disposed = false;


        public Dictionary<EndPoint, AsyncSocketState> clients { get => _clients; set => _clients = value; }
        #endregion

        #region Properties

        /// <summary>
        /// 服务器是否正在运行
        /// </summary>
        public bool isRunning { get; private set; }
        /// <summary>
        /// 监听的IP地址
        /// </summary>
        public IPAddress address { get; private set; }
        /// <summary>
        /// 监听的端口
        /// </summary>
        public int port { get; private set; }
        /// <summary>
        /// 通信使用的编码
        /// </summary>
        public Encoding encoding { get; set; }

        public bool CanSend { get; set; }

        #endregion

        #region 构造函数

        /// <summary>
        /// 异步Socket TCP服务器
        /// </summary>
        /// <param name="listenPort">监听的端口</param>
        public AsyncSocketTCPServer(int listenPort)
            : this(IPAddress.Any, listenPort, 1024)
        {
        }

        /// <summary>
        /// 异步Socket TCP服务器
        /// </summary>
        /// <param name="localEP">监听的终结点</param>
        public AsyncSocketTCPServer(IPEndPoint localEP)
            : this(localEP.Address, localEP.Port, 1024)
        {
        }

        /// <summary>
        /// 异步Socket TCP服务器
        /// </summary>
        /// <param name="localIPAddress">监听的IP地址</param>
        /// <param name="listenPort">监听的端口</param>
        /// <param name="maxClient">最大客户端数量</param>
        public AsyncSocketTCPServer(IPAddress localIPAddress, int listenPort, int maxClient)
        {
            this.address = localIPAddress;
            this.port = listenPort;
            this.encoding = Encoding.Default;

            _maxClient = maxClient;
            _clients = new Dictionary<EndPoint, AsyncSocketState>();
            CanSend = true;
            _serverSock = new Socket(localIPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        #endregion

        #region Method

        /// <summary>
        /// 启动服务器
        /// </summary>
        public void Start()
        {
            if (!isRunning)
            {
                isRunning = true;
                _serverSock.Bind(new IPEndPoint(this.address, this.port));
                _serverSock.Listen(1024);
                _serverSock.BeginAccept(new AsyncCallback(HandleAcceptConnected), _serverSock);
            }
        }

        /// <summary>
        /// 启动服务器
        /// </summary>
        /// <param name="backlog">
        /// 服务器所允许的挂起连接序列的最大长度
        /// </param>
        public void Start(int backlog)
        {
            if (!isRunning)
            {
                isRunning = true;
                _serverSock.Bind(new IPEndPoint(this.address, this.port));
                _serverSock.Listen(backlog);
                _serverSock.BeginAccept(new AsyncCallback(HandleAcceptConnected), _serverSock);
            }
        }

        /// <summary>
        /// 停止服务器
        /// </summary>        
        public void Stop()
        {
            if (isRunning)
            {
                isRunning = false;
                _serverSock.Close();
                //TODO 关闭对所有客户端的连接

            }
        }

        /// <summary>
        /// 处理客户端连接
        /// </summary>
        /// <param name="ar"></param>
        private void HandleAcceptConnected(IAsyncResult ar)
        {
            if (isRunning)
            {
                Socket server = (Socket)ar.AsyncState;
                Socket client = server.EndAccept(ar);

                //检查是否达到最大的允许的客户端数目
                if (_clientCount >= _maxClient)
                {
                    //C-TODO 触发事件
                    RaiseOtherException(null);
                }
                else
                {
                    AsyncSocketState state = new AsyncSocketState(client);
                    lock(_clients)
                    {
                        _clients.Add(client.RemoteEndPoint,state);
                        _clientCount++;
                        RaiseClientConnected(state); //触发客户端连接事件
                    }
                    state.recvDataBuffer = new byte[client.ReceiveBufferSize];
                    //开始接受来自该客户端的数据
                    client.BeginReceive(state.recvDataBuffer, 0, state.recvDataBuffer.Length, SocketFlags.None,
                                        new AsyncCallback(HandleDataReceived), state);
                }
                //接受下一个请求
                server.BeginAccept(new AsyncCallback(HandleAcceptConnected), ar.AsyncState);
            }
        }
        /// <summary>
        /// 处理客户端数据
        /// </summary>
        /// <param name="ar"></param>
        private void HandleDataReceived(IAsyncResult ar)
        {
            if (isRunning)
            {
                AsyncSocketState state = (AsyncSocketState)ar.AsyncState;
                Socket client = state.clientSocket;
                try
                {
                    //如果两次开始了异步的接收,所以当客户端退出的时候
                    //会两次执行EndReceive
                    int recv = client.EndReceive(ar);
                    if (recv == 0)
                    {
                        //C- TODO 触发事件 (关闭客户端)
                        Close(state);
                        RaiseNetError(state);
                        return;
                    }
                    //TODO 处理已经读取的数据 ps:数据在state的RecvDataBuffer中

                    //C- TODO 触发数据接收事件
                    state.recvLen = recv;
                    RaiseDataReceived(state);
                    //继续接收来自来客户端的数据
                    client.BeginReceive(state.recvDataBuffer, 0, state.recvDataBuffer.Length, SocketFlags.None,
                                        new AsyncCallback(HandleDataReceived), state);
                }
                catch (SocketException)
                {
                    //C- TODO 异常处理
                    RaiseNetError(state);
                }
                finally
                {

                }
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="state">接收数据的客户端会话</param>
        /// <param name="data">数据报文</param>
        public void Send(AsyncSocketState state, byte[] data)
        {

            RaisePrepareSend(state);
            if(state.clientSocket!=null)
            {
                Send(state.clientSocket, data);
            }
        }

        public void SendAll(byte[] data)
        {
            foreach (AsyncSocketState asyncSocket in clients.Values)
            {
                Send(asyncSocket, data);
            }
        }

        /// <summary>
        /// 异步发送数据至指定的客户端
        /// </summary>
        /// <param name="client">客户端</param>
        /// <param name="data">报文</param>
        public void Send(Socket client, byte[] data)
        {
            if (!isRunning)
            {
                throw new InvalidProgramException("This TCP Scoket server has not been started.");
            }

            if (client == null)
            {
                throw new ArgumentNullException("client");
            }
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }
                
            CanSend = false;
            
            client.BeginSend(data, 0, data.Length, SocketFlags.None,
             new AsyncCallback(SendDataEnd), client);

        }
                
        /// <summary>
        /// 发送数据完成处理函数
        /// </summary>
        /// <param name="ar">目标客户端Socket</param>
        private void SendDataEnd(IAsyncResult ar)
        {
            ((Socket)ar.AsyncState).EndSend(ar);
            CanSend = true;
            RaiseCompletedSend(null);
        }
        #endregion

        #region 事件

        /// <summary>
        /// 与客户端的连接已建立事件
        /// </summary>
        public event EventHandler<AsyncSocketEventArgs> ClientConnected;
        /// <summary>
        /// 与客户端的连接已断开事件
        /// </summary>
        public event EventHandler<AsyncSocketEventArgs> ClientDisconnected;

        /// <summary>
        /// 触发客户端连接事件
        /// </summary>
        /// <param name="state"></param>
        private void RaiseClientConnected(AsyncSocketState state)
        {
            if (ClientConnected != null)
            {
                ClientConnected(this, new AsyncSocketEventArgs(state));
            }
        }
        /// <summary>
        /// 触发客户端连接断开事件
        /// </summary>
        /// <param name="client"></param>
        private void RaiseClientDisconnected(Socket client)
        {
            if (ClientDisconnected != null)
            {
                ClientDisconnected(this, new AsyncSocketEventArgs("连接断开"));
            }
        }

        /// <summary>
        /// 接收到数据事件
        /// </summary>
        public event EventHandler<AsyncSocketEventArgs> DataReceived;

        private void RaiseDataReceived(AsyncSocketState state)
        {
            if (DataReceived != null)
            {
                DataReceived(this, new AsyncSocketEventArgs(state));
            }
        }

        /// <summary>
        /// 发送数据前的事件
        /// </summary>
        public event EventHandler<AsyncSocketEventArgs> PrepareSend;

        /// <summary>
        /// 触发发送数据前的事件
        /// </summary>
        /// <param name="state"></param>
        private void RaisePrepareSend(AsyncSocketState state)
        {
            if (PrepareSend != null)
            {
                PrepareSend(this, new AsyncSocketEventArgs(state));
            }
        }

        /// <summary>
        /// 数据发送完毕事件
        /// </summary>
        public event EventHandler<AsyncSocketEventArgs> CompletedSend;

        /// <summary>
        /// 触发数据发送完毕的事件
        /// </summary>
        /// <param name="state"></param>
        private void RaiseCompletedSend(AsyncSocketState state)
        {
            if (CompletedSend != null)
            {
                CompletedSend(this, new AsyncSocketEventArgs(state));
            }
        }

        /// <summary>
        /// 网络错误事件
        /// </summary>
        public event EventHandler<AsyncSocketEventArgs> NetError;
        /// <summary>
        /// 触发网络错误事件
        /// </summary>
        /// <param name="state"></param>
        private void RaiseNetError(AsyncSocketState state)
        {
            if (NetError != null)
            {
                NetError(this, new AsyncSocketEventArgs(state));
            }
        }

        /// <summary>
        /// 异常事件
        /// </summary>
        public event EventHandler<AsyncSocketEventArgs> OtherException;
        /// <summary>
        /// 触发异常事件
        /// </summary>
        /// <param name="state"></param>
        private void RaiseOtherException(AsyncSocketState state, string descrip)
        {
            if (OtherException != null)
            {
                OtherException(this, new AsyncSocketEventArgs(descrip, state));
            }
        }
        private void RaiseOtherException(AsyncSocketState state)
        {
            RaiseOtherException(state, "");
        }
        #endregion

        #region Close
        /// <summary>
        /// 关闭一个与客户端之间的会话
        /// </summary>
        /// <param name="state">需要关闭的客户端会话对象</param>
        public void Close(AsyncSocketState state)
        {
            if (state != null)
            {
                state.datagram = null;
                state.recvDataBuffer = null;

                _clients.Remove(state.clientSocket.RemoteEndPoint);
                _clientCount--;
                //TODO 触发关闭事件
                state.Close();
            }
        }
        /// <summary>
        /// 关闭所有的客户端会话,与所有的客户端连接会断开
        /// </summary>
        public void CloseAllClient()
        {
            foreach (AsyncSocketState client in _clients.Values)
            {
                Close(client);
            }
            _clientCount = 0;
            _clients.Clear();
        }
        #endregion

        #region 释放
        /// <summary>
        /// Performs application-defined tasks associated with freeing, 
        /// releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources
        /// </summary>
        /// <param name="disposing"><c>true</c> to release 
        /// both managed and unmanaged resources; <c>false</c> 
        /// to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    try
                    {
                        Stop();
                        if (_serverSock != null)
                        {
                            _serverSock = null;
                        }
                    }
                    catch (SocketException)
                    {
                        //TODO
                        RaiseOtherException(null);
                    }
                }
                disposed = true;
            }
        }
        #endregion
    }
    /// <summary>
    /// 异步Socket TCP事件参数类
    /// </summary>
    public class AsyncSocketEventArgs : EventArgs
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        public string _msg;

        /// <summary>
        /// 客户端状态封装类
        /// </summary>
        public AsyncSocketState _state;

        /// <summary>
        /// 是否已经处理过了
        /// </summary>
        public bool isHandled { get; set; }

        public AsyncSocketEventArgs(string msg)
        {
            this._msg = msg;
            isHandled = false;
        }
        public AsyncSocketEventArgs(AsyncSocketState state)
        {
            this._state = state;
            isHandled = false;
        }
        public AsyncSocketEventArgs(string msg, AsyncSocketState state)
        {
            this._msg = msg;
            this._state = state;
            isHandled = false;
        }
    }
    /// <summary>
    /// 异步SOCKET TCP 中用来存储客户端状态信息的类
    /// </summary>
    public class AsyncSocketState
    {
        #region 字段
        private int _recvLen;
        /// <summary>
        /// 接收数据缓冲区
        /// </summary>
        private byte[] _recvBuffer;

        /// <summary>
        /// 客户端发送到服务器的报文
        /// 注意:在有些情况下报文可能只是报文的片断而不完整
        /// </summary>
        private string _datagram;

        /// <summary>
        /// 客户端的Socket
        /// </summary>
        private Socket _clientSock;

        #endregion

        #region 属性

        /// <summary>
        /// 接收数据缓冲区 
        /// </summary>
        public byte[] recvDataBuffer
        {
            get
            {
                return _recvBuffer;
            }
            set
            {
                _recvBuffer = value;
            }
        }

        public int recvLen { get => _recvLen; set => _recvLen = value; }

        /// <summary>
        /// 存取会话的报文
        /// </summary>
        public string datagram
        {
            get
            {
                return _datagram;
            }
            set
            {
                _datagram = value;
            }
        }

        /// <summary>
        /// 获得与客户端会话关联的Socket对象
        /// </summary>
        public Socket clientSocket
        {
            get
            {
                return _clientSock;

            }
        }


        #endregion

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="cliSock">会话使用的Socket连接</param>
        public AsyncSocketState(Socket cliSock)
        {
            _clientSock = cliSock;
        }

        ///// <summary>
        ///// 初始化数据缓冲区
        ///// </summary>
        //public void InitBuffer()
        //{
        //    if (_recvBuffer == null && _clientSock != null)
        //    {
        //        _recvBuffer = new byte[_clientSock.ReceiveBufferSize];
        //    }
        //}

        /// <summary>
        /// 关闭会话
        /// </summary>
        public void Close()
        {

            //关闭数据的接受和发送
            _clientSock.Shutdown(SocketShutdown.Both);

            //清理资源
            _clientSock.Close();
        }
    }
}
