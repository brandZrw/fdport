using FDPort.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FDPort.FieldModuleClass
{
    public class FieldRegex : FieldModule
    {
        public string regexStr;
        Regex reg;
        public string[] groups;
        public override object List2Value(byte[] t)
        {
            return null;
        }
        public override byte[] Value2List(object v)
        {
            List<string> input = new List<string>();
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string,FieldSendParam> pair in Project.param.sendMap)
            {
                input.Add(pair.Value.value);
                
                sb.Append("(?<");
                sb.Append(pair.Key);
                sb.Append(">[^,]*),");
            }
            foreach (KeyValuePair<string, FieldRecvParam> pair in Project.param.recvMap)
            {
                input.Add(pair.Value.ShowValue());

                sb.Append("(?<");
                sb.Append(pair.Key);
                sb.Append(">[^,]*),");
            }
            string i = string.Join(",", input.ToArray());
            i = i + ",";
            string b = sb.ToString();
            Match m = Regex.Match(i,b);
            if(m.Success)
            {
                string x = m.Result(regexStr);
                return System.Text.Encoding.UTF8.GetBytes(x);
            }
            
            return null;
        }
        public override bool IsParse(byte[] b, ref int useLen, byte[] vs = null)
        {
            string str = System.Text.Encoding.UTF8.GetString(b);
            if(reg?.IsMatch(str) == true)
            {
                Match m = reg.Match(str);
                
                foreach(Group group in m.Groups)
                {
                    if (Project.param.recvMap.ContainsKey(group.Name))
                    {
                        Project.param.recvMap[group.Name].tempValue = group.Value;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SetRegex(string re)
        {
            regexStr = re;
            reg = new Regex(re);
            List<string> temp = new List<string>(reg.GetGroupNames());
            temp.RemoveAt(0);

            groups = temp.ToArray();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("正则表达式:");
            sb.Append(regexStr);
            
            return sb.ToString();
        }
    }
}
