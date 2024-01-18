using FDPort.Class;
using FDPort.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void cmdList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex != -1 && e.ColumnIndex != -1)
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
