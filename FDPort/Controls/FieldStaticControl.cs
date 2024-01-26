using FDPort.FieldModuleClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FDPort.Controls
{
    public partial class FieldStaticControl : FieldBaseControl
    {
        public FieldStaticControl()
        {
            InitializeComponent();
        }
        public override void SetModule(FieldModule field)
        {
            FieldStatic cmd = field as FieldStatic;
            cmdStaticIsString.Checked = cmd.isString;
            if (cmd.isString)
            {
                cmdStaticValue.Text = System.Text.Encoding.UTF8.GetString(cmd.array.ToArray());
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                foreach (byte b in cmd.array)
                {
                    sb.Append(b.ToString("X2"));
                    sb.Append(" ");
                }
                sb.Remove(sb.Length - 1, 1);
                cmdStaticValue.Text = sb.ToString();
            }
        }
        public override FieldModule GetModule(string name)
        {
            try
            {
                FieldStatic cmd = new FieldStatic();
                cmd.type = FieldModule.CM_Type.CM_STATIC;
                cmd.name = name;
                cmd.isString = cmdStaticIsString.Checked;
                if (cmdStaticIsString.Checked)
                {
                    string t = cmdStaticValue.Text;
                    cmd.len = t.Length;
                    cmd.array = new List<byte>(System.Text.Encoding.UTF8.GetBytes(t));
                }
                else
                {
                    Regex r = new Regex(@"\s{1,}", RegexOptions.IgnoreCase);
                    string t = r.Replace(cmdStaticValue.Text.Trim(), " ").Trim();
                    string[] vs = t.Split();
                    cmd.array = new List<byte>();
                    foreach (string s in vs)
                    {
                        cmd.array.Add(Convert.ToByte(s, 16));
                    }
                    cmd.len = cmd.array.Count;
                }
                return cmd;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }
    }
}
