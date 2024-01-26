using FDPort.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace FDPort.Class
{
    public class NotifyClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    class common
    {
        public static string ByteArrayToString(byte[] vs, int len)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                sb.Append(vs[i].ToString("X2"));
                sb.Append(' ');
            }
            return sb.ToString();
        }
        /// 将DataTable中数据写入到CSV文件中
        /// </summary>
        /// <param name="dt">提供保存数据的DataTable</param>
        /// <param name="fileName">CSV的文件路径</param>
        public static void SaveDataTableCSV(string path, DataTable dt)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            StringBuilder sb = new StringBuilder();
            fs.SetLength(0);
            sb.Clear();

            //写出列名称
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                sb.Append(dt.Columns[i].ColumnName.ToString());
                if (i < dt.Columns.Count - 1)
                {
                    sb.Append("\t");
                }
            }
            sw.WriteLine(sb.ToString());

            //写出各行数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                sb.Clear();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    sb.Append(dt.Rows[i][j].ToString());
                    if (j < dt.Columns.Count - 1)
                    {
                        sb.Append("\t");
                    }
                }
                sw.WriteLine(sb.ToString());
            }

            sw.Close();
            fs.Close();
        }
        public static byte[] String2Byte(string str, int len)
        {
            byte[] decBytes = System.Text.Encoding.UTF8.GetBytes(str);
            List<byte> ls = new List<byte>(decBytes);
            ls.Add(0);//添加尾部的0
            if (len == 0)
            {
                return ls.ToArray();
            }
            else
            {
                if (len <= ls.Count)
                {
                    return ls.Take(len).ToArray();
                }
                else
                {
                    byte[] vs = new byte[len];
                    ls.CopyTo(vs, 0);
                    return vs;
                }
            }
        }

        public static string Byte2String(byte[] bytes, int len, out int useLen)
        {
            if (len == 0)
            {
                int index = 0;
                List<byte> ls = new List<byte>();
                for (int i = 0; i < bytes.Length; i++)
                {
                    index++;
                    if (bytes[i] != 0)
                    {
                        ls.Add(bytes[i]);
                    }
                    else
                    {
                        break;
                    }
                }
                useLen = index;
                return System.Text.Encoding.UTF8.GetString(ls.ToArray());
            }
            else
            {
                List<byte> ls = new List<byte>();
                for (int i = 0; i < len; i++)
                {
                    if (bytes[i] != 0)
                    {
                        ls.Add(bytes[i]);
                    }
                    else
                    {
                        break;
                    }
                }
                useLen = len;
                return System.Text.Encoding.UTF8.GetString(ls.ToArray());
            }

        }
        public static bool IsNumeric(string text)
        {
            decimal t = 0;
            return decimal.TryParse(text, out t);
        }
        public static bool ByteEquals(byte[] src, byte[] dsr)
        {
            if (src.Length < dsr.Length)
            {
                return false;
            }
            for (int i = 0; i < dsr.Length; i++)
            {
                if (dsr[i] != src[i])
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 将对象转换为byte数组
        /// </summary>
        /// <param name="obj">被转换对象</param>
        /// <returns>转换后byte数组</returns>
        public static byte[] Object2Bytes(object obj)
        {
            byte[] buff;
            using (MemoryStream ms = new MemoryStream())
            {
                IFormatter iFormatter = new BinaryFormatter();
                iFormatter.Serialize(ms, obj);
                buff = ms.GetBuffer();
            }
            return buff;
        }

        /// <summary>
        /// 将byte数组转换成对象
        /// </summary>
        /// <param name="buff">被转换byte数组</param>
        /// <returns>转换完成后的对象</returns>
        public static object Bytes2Object(byte[] buff)
        {
            object obj;
            using (MemoryStream ms = new MemoryStream(buff))
            {
                IFormatter iFormatter = new BinaryFormatter();
                obj = iFormatter.Deserialize(ms);
            }
            return obj;
        }

        /// <summary>
        /// 类完全复制
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="tIn"></param>
        /// <returns></returns>
        public static T TransReflection<T>(T tIn)
        {
            if (tIn == null)
            {
                return default(T);
            }
            T tOut = Activator.CreateInstance<T>();
            var tInType = tIn.GetType();
            foreach (var itemOut in tOut.GetType().GetProperties())
            {
                var itemIn = tInType.GetProperty(itemOut.Name); ;
                if (itemIn != null)
                {
                    itemOut.SetValue(tOut, itemIn.GetValue(tIn));
                }
            }
            return tOut;
        }
        /// <summary>
        /// 类完全复制
        /// </summary>
        /// <typeparam name="TIn"></typeparam>
        /// <typeparam name="TOut"></typeparam>
        /// <param name="tIn"></param>
        /// <returns></returns>
        public static void CopyTo<T>(T tIn, T tOut)
        {
            var tInType = tIn.GetType();
            foreach (var itemOut in tOut.GetType().GetProperties())
            {
                var itemIn = tInType.GetProperty(itemOut.Name); ;
                if (itemIn != null)
                {
                    itemOut.SetValue(tOut, itemIn.GetValue(tIn));
                }
            }
        }
        public static PortBase GetPort(PortBase from) => Project.param.needForwarding? (from == Project.param.portNow? Project.param.portForwarding : Project.param.portNow) : from ;

        public static string[] GetComList()
        {
            Microsoft.Win32.RegistryKey keyCom = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
            if (keyCom != null)
            {
                string[] sSubKeys = keyCom.GetValueNames();
                string[] str = new string[sSubKeys.Length];
                for (int i = 0; i < sSubKeys.Length; i++)
                {
                    str[i] = (string)keyCom.GetValue(sSubKeys[i]);
                }
                return str;
            }
            return null;

        }
    }
}
