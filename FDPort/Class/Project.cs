using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using FDPort.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using FDPort.Communication;
using FDPort.FieldModuleClass;

namespace FDPort.Class
{
    // 系统配置参数
    class ProjectParam: NotifyClass
    {
        #region 序列化参数
        private bool _isLittleEndian { get; set; }
        private string _timeout { get; set; }
        //ui
        private bool _addTimestamp { get; set; }
        // serial
        private string _baud { get; set; }
        private string _com { get; set; }
        // client
        private string _cIP { get; set; }
        private string _cPort { get; set; }
        // service
        private string _sIP { get; set; }
        private string _sPort { get; set; }
        private int _portChoose { get; set; }


        ObservableCollection<CmdRecv> _cmdRecv = new ObservableCollection<CmdRecv>();
        ObservableCollection<CmdSend> _cmdSend = new ObservableCollection<CmdSend>();
        ObservableCollection<UnitTestObject> _unitTests = new ObservableCollection<UnitTestObject>();

        public bool isLittleEndian { get => _isLittleEndian; set{_isLittleEndian = value; OnPropertyChanged();} }
        public string timeout { get => _timeout; set{_timeout = value; OnPropertyChanged();} }
        //ui

        public bool addTimestamp { get => _addTimestamp; set { _addTimestamp = value; OnPropertyChanged(); } }
        // serial
        public string baud { get => _baud; set{_baud = value; OnPropertyChanged();} }
        public string com { get => _com; set{_com = value; OnPropertyChanged();} }
        // client
        public string cIP { get => _cIP; set{_cIP = value; OnPropertyChanged();} }
        public string cPort { get => _cPort; set{_cPort = value; OnPropertyChanged();} }
        // service
        public string sIP { get => _sIP; set{_sIP = value; OnPropertyChanged();} }
        public string sPort { get => _sPort; set{_sPort = value; OnPropertyChanged();} }
        public int portChoose { get => _portChoose; set{_portChoose = value; OnPropertyChanged();} }

        public ObservableCollection<CmdRecv> cmdRecv { get => _cmdRecv; set => _cmdRecv = value; }
        public ObservableCollection<CmdSend> cmdSend { get => _cmdSend; set => _cmdSend = value; }
        public ObservableDictionary<string, FieldSendParam> sendMap = new ObservableDictionary<string, FieldSendParam>();
        public ObservableDictionary<string, FieldRecvParam> recvMap = new ObservableDictionary<string, FieldRecvParam>();
        public List<string> showRecMap = new List<string>();
        public ObservableCollection<UnitTestObject> unitTests { get => _unitTests; set => _unitTests = value; }
        public string layout { get; set; }
        public bool needForwarding { get; set; }
        public PortBase portForwarding { get; set; }
        public PortBase portNow { get; set; }
        public int DataCacheLen { get; set; }
        #endregion
    }

    class ProjectParamOldVersion : NotifyClass
    {
        #region 序列化参数
        private bool _isLittleEndian { get; set; }
        private string _timeout { get; set; }
        private bool _recHex { get; set; }
        private bool _sendHex { get; set; }
        //ui
        private bool _recUI { get; set; }
        private bool _setUI { get; set; }
        private bool _chartUI { get; set; }
        private bool _cmdUI { get; set; }
        private bool _configUI { get; set; }
        private bool _addTimestamp { get; set; }
        // serial
        private string _baud { get; set; }
        private string _com { get; set; }
        // client
        private string _cIP { get; set; }
        private string _cPort { get; set; }
        // service
        private string _sIP { get; set; }
        private string _sPort { get; set; }
        private int _portChoose { get; set; }


        ObservableCollection<CmdRecv> _cmdRecv = new ObservableCollection<CmdRecv>();
        ObservableCollection<CmdSend> _cmdSend = new ObservableCollection<CmdSend>();
        ObservableCollection<UnitTestObject> _unitTests = new ObservableCollection<UnitTestObject>();

        public bool isLittleEndian { get => _isLittleEndian; set { _isLittleEndian = value; OnPropertyChanged(); } }
        public string timeout { get => _timeout; set { _timeout = value; OnPropertyChanged(); } }
        public bool recHex { get => _recHex; set { _recHex = value; OnPropertyChanged(); } }
        public bool sendHex { get => _sendHex; set { _sendHex = value; OnPropertyChanged(); } }
        //ui
        public bool recUI { get => _recUI; set { _recUI = value; OnPropertyChanged(); } }
        public bool setUI { get => _setUI; set { _setUI = value; OnPropertyChanged(); } }
        public bool chartUI { get => _chartUI; set { _chartUI = value; OnPropertyChanged(); } }
        public bool cmdUI { get => _cmdUI; set { _cmdUI = value; OnPropertyChanged(); } }
        public bool configUI { get => _configUI; set { _configUI = value; OnPropertyChanged(); } }
        public bool addTimestamp { get => _addTimestamp; set { _addTimestamp = value; OnPropertyChanged(); } }
        // serial
        public string baud { get => _baud; set { _baud = value; OnPropertyChanged(); } }
        public string com { get => _com; set { _com = value; OnPropertyChanged(); } }
        // client
        public string cIP { get => _cIP; set { _cIP = value; OnPropertyChanged(); } }
        public string cPort { get => _cPort; set { _cPort = value; OnPropertyChanged(); } }
        // service
        public string sIP { get => _sIP; set { _sIP = value; OnPropertyChanged(); } }
        public string sPort { get => _sPort; set { _sPort = value; OnPropertyChanged(); } }
        public int portChoose { get => _portChoose; set { _portChoose = value; OnPropertyChanged(); } }

        public ObservableCollection<CmdRecv> cmdRecv { get => _cmdRecv; set => _cmdRecv = value; }
        public ObservableCollection<CmdSend> cmdSend { get => _cmdSend; set => _cmdSend = value; }
        public ObservableDictionary<string, string> sendMap = new ObservableDictionary<string, string>();
        public ObservableDictionary<string, FieldRecvParam> recvMap = new ObservableDictionary<string, FieldRecvParam>();
        public List<string> showRecMap = new List<string>();
        public ObservableCollection<UnitTestObject> unitTests { get => _unitTests; set => _unitTests = value; }
        #endregion

        public ProjectParam ToParam()
        {
            ProjectParam temp = new ProjectParam();
            temp.isLittleEndian = isLittleEndian;
            temp.portChoose = portChoose;
            temp.addTimestamp = addTimestamp;
            temp.baud = baud;
            temp.cIP = cIP;
            temp.cmdRecv = new ObservableCollection<CmdRecv>(cmdRecv);
            temp.cmdSend = new ObservableCollection<CmdSend>(cmdSend);
            temp.com = com;
            temp.cPort = cPort;
            temp.showRecMap = new List<string>(showRecMap);
            temp.sIP = sIP;
            temp.sPort = sPort;
            temp.timeout = timeout;
            temp.DataCacheLen = 1024;
            foreach (KeyValuePair<string, FieldRecvParam> t in recvMap)
            {
                foreach (CmdRecv cmd in temp.cmdRecv)
                {
                    foreach (FieldModule mo in cmd.list)
                    {
                        if (mo is FieldByte)
                        {
                            FieldByte field = mo as FieldByte;
                            if (!string.IsNullOrWhiteSpace(field.name) && mo.name.Equals(t.Key))
                            {
                                t.Value.SetValueType(field.byteType);
                                goto next;
                            }
                        }
                    }
                }
                t.Value.SetValueType(FieldByte.CM_BYTE_TYPE.CM_BYTE_UINT);
next:
                temp.recvMap.Add(t.Key, t.Value);
            }
            foreach (KeyValuePair<string, string> s in sendMap)
            {
                temp.sendMap.Add(s.Key, new FieldSendParam(s.Value));
            }

            foreach (UnitTestObject obj in unitTests)
            {
                temp.unitTests.Add(obj);
            }

            return temp;

        }
    }
    static class Project
    {
        private static ProjectParam _param = new ProjectParam();
        public static MainForm mainForm { get; set; }
        public static ProjectParam param { get => _param; set { _param = value; } }
        public static ScriptEngine pyEngine;
        public static ScriptScope scope;
        public static string Version = "V1.0.4";
        public static void init()
        {
            pyEngine = Python.CreateEngine();//创建Python解释器对象
            scope = pyEngine.CreateScope();
        }
        private static bool isShowing = false;
        /// <summary>
        /// 执行脚本文件
        /// </summary>
        /// <param name="scriptPath">脚本所在位置</param>
        /// <param name="vs">接收或发送的数组</param>
        /// <param name="Param">参数</param>
        /// <returns></returns>
        public static object RunPython(string scriptPath, byte[] vs, object Param)
        {
            try
            {
                object valueObj = null;
                dynamic pyFunc = pyEngine.ExecuteFile(scriptPath, scope);//读取脚本文件
                if (pyFunc != null)
                {
                    if (param == null)
                    {
                        valueObj = pyFunc.main(vs);
                        //scope.TryGetVariable("param", out outValue);
                    }
                    else
                    {
                        valueObj = pyFunc.main(vs, Param);
                        //scope.TryGetVariable("param", out outValue);
                    }
                }
                return valueObj;
            }
            catch (Exception e)
            {
                if (isShowing == false)
                {
                    isShowing = true;//只显示一个窗口
                    System.Windows.Forms.MessageBox.Show("python执行错误:" + e.Message);
                    isShowing = false;
                }
                //MessageBox.Show("脚本运行错误" + e.Message);// 用这句会使得窗口变小
            }
            return null;
        }
        public static void Load(string t)
        {
            var setting = new JsonSerializerSettings
            {
                Converters = new List<JsonConverter>
                {
                    new JsonFieldModule()
                }
            };
            try
            {
                param = (ProjectParam)JsonConvert.DeserializeObject(File.ReadAllText(t), typeof(ProjectParam), setting);
            }
            catch (Exception e)
            {
                ProjectParamOldVersion type = (ProjectParamOldVersion)JsonConvert.DeserializeObject(File.ReadAllText(t), typeof(ProjectParamOldVersion), setting);
                param = type.ToParam();
            }
            if(param.DataCacheLen == 0)
            {
                param.DataCacheLen = 1024;
            }
        }

        public static void Save(string t)
        {
            string info = JsonConvert.SerializeObject(param);
            File.WriteAllText(t, info);
        }
    }
}
