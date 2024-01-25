using FDPort.Class;
using FDPort.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace FDPort.DockPanel
{
    public partial class SendCmdDock : DockContent
    {
        public SendCmdDock()
        {
            InitializeComponent();
            TabText = "发送命令";
            CloseButton = false;
            CloseButtonVisible = false;
        }


        #region 剪切板
        [DllImport("User32")]
        public static extern bool OpenClipboard(IntPtr hWndNewOwner);

        [DllImport("User32")]
        public static extern bool CloseClipboard();

        [DllImport("User32")]
        public static extern bool EmptyClipboard();

        [DllImport("User32")]
        public static extern bool IsClipboardFormatAvailable(int format);

        [DllImport("User32")]
        public static extern IntPtr GetClipboardData(int uFormat);

        [DllImport("User32", CharSet = CharSet.Unicode)]
        public static extern IntPtr SetClipboardData(int uFormat, IntPtr hMem);

        private const int CF_UNICODETEXT = 13;
        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (OpenClipboard(IntPtr.Zero))
                {
                    if (cmdList.SelectedRows.Count > 0)
                    {
                        SetClipboardData(CF_UNICODETEXT, Marshal.StringToHGlobalUni(JsonConvert.SerializeObject(Project.param.cmdSend[cmdList.SelectedRows[0].Index])));

                    }

                    CloseClipboard();
                }
            }
            else if (e.Control && e.KeyCode == Keys.V)
            {
                if (OpenClipboard(IntPtr.Zero))
                {
                    try
                    {
                        string ss = Marshal.PtrToStringUni(GetClipboardData(CF_UNICODETEXT));
                        var setting = new JsonSerializerSettings
                        {
                            Converters = new List<JsonConverter>
                        {
                            new JsonFieldModule()
                        }
                        };
                        CmdSend module = (CmdSend)JsonConvert.DeserializeObject(ss, typeof(CmdSend), setting);
                        Project.param.cmdSend.Add(module);
                        cmdList.Rows.Add(module.name, null, module.autoSend, module.sendTime);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        CloseClipboard();
                    }
                }
            }
        }
        #endregion

        #region event
        private void cmdList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //点击button按钮事件
            if (cmdList.Columns[e.ColumnIndex].Name == "cmdSend" && Project.param.cmdSend.Count > 0 && e.RowIndex >= 0 && e.RowIndex < Project.param.cmdSend.Count)
            {
                //说明点击的列是DataGridViewButtonColumn列
                Project.param.cmdSend[e.RowIndex].Send(common.GetPort(Project.param.portNow));
            }
            else if (cmdList.Columns[e.ColumnIndex].Name == "cmdTimer" && Project.param.cmdSend.Count > 0 && e.RowIndex >= 0 && e.RowIndex < Project.param.cmdSend.Count)
            {
                //说明点击的列是DataGridViewButtonColumn列
                cmdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !(bool)cmdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                Project.param.cmdSend[e.RowIndex].autoSend = (bool)cmdList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }
        private void cmdList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.RowIndex != -1 && e.ColumnIndex != -1)
            if (e.ColumnIndex != 1 && e.ColumnIndex != 2)
            {
                if (e.RowIndex >= Project.param.cmdSend.Count || e.RowIndex == -1) // 新增
                {
                    CmdSendStruct cmdStruct = CmdSendStruct.GetInstance();
                    cmdStruct.Show();
                }
                else
                {
                    CmdSendStruct cmdStruct = CmdSendStruct.GetInstance(e.RowIndex);
                    cmdStruct.Show();
                }
            }
        }
        private void cmdList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (e.RowIndex < Project.param.cmdSend.Count)
            {
                Project.param.cmdSend.RemoveAt(e.RowIndex);
            }
        }
        #endregion

        
    }
}
