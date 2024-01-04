using DynamicExpresso;
using FDPort.Class;
using FDPort.Controls;
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

namespace FDPort.Forms
{
    public partial class CmdSendStruct : System.Windows.Forms.Form
    {
        public CmdSend item = new CmdSend();
        private int index = -1;

        public CmdSendStruct()
        {
            InitializeComponent();
            cmdDataGridList.SetItems(item.list);
        }
        public CmdSendStruct(int index)
        {
            InitializeComponent();
            this.index = index;
            this.item = common.TransReflection(Project.param.cmdSend.ElementAt(index));
            item.cmdTimer.Enabled = false;//防止定时器开启

            cmdDataGridList.SetItems(item.list);
            CmdSendName.Text = item.name;
            autoSend.Checked = item.autoSend;
            autoSendTime.Text = item.sendTime.ToString();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            cmdDataGridList.CmdNewPage();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            try
            {
                item.name = CmdSendName.Text;
                item.autoSend = autoSend.Checked;
                item.list = cmdDataGridList.items;
                if (string.IsNullOrEmpty(autoSendTime.Text))
                {
                    item.sendTime = 0;
                }
                else
                {
                    item.sendTime = Convert.ToInt32(autoSendTime.Text);
                }
                System.Windows.Forms.DataGridView cmdList = Project.mainForm.getCmdList();

                if (index == -1)
                {
                    Project.param.cmdSend.Add(item);
                    cmdList.Rows.Add(item.name, null, item.autoSend, item.sendTime);
                }
                else
                {
                    CmdSend cmd = Project.param.cmdSend.ElementAt(index);
                    bool autoSend = item.autoSend;//记录定时器状态
                    common.Copyto(item, cmd);
                    cmd.autoSend = autoSend;//防止原来开启定时器的，因为复制之后会关闭定时器，此时开启

                    cmdList.Rows[index].Cells[0].Value = cmd.name;
                    cmdList.Rows[index].Cells[2].Value = cmd.autoSend;
                    cmdList.Rows[index].Cells[3].Value = cmd.sendTime;
                }

                foreach (FieldModule t in item.list)
                {
                    if (t.type == FieldModule.CM_Type.CM_DATA)// 尚未添加的参数将会被添加
                    {
                        FieldData data = (FieldData)t;
                        var interpreter = new Interpreter();
                        var variable = interpreter.DetectIdentifiers(data.link);
                        foreach (string varStr in variable.UnknownIdentifiers)
                        {
                            if (!Project.param.sendMap.ContainsKey(varStr) && !Project.param.showRecMap.Contains(varStr))
                            {
                                FieldSendParam temp = new FieldSendParam(data.dataType == FieldData.DataType.NUM ? "0" : "abc");
                                Project.param.sendMap.Add(varStr, temp);
                            }
                        }

                    }
                }
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
            finally
            {
                Close();
            }
        }

        private void CmdSendStruct_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    cmdDataGridList.CmdNewPage(0);
                    break;
                case Keys.F2:
                    cmdDataGridList.CmdNewPage(1);
                    break;
                case Keys.F3:
                    cmdDataGridList.CmdNewPage(2);
                    break;
                case Keys.F4:
                    cmdDataGridList.CmdNewPage(3);
                    break;
                case Keys.F5:
                    cmdDataGridList.CmdNewPage(4);
                    break;

            }
        }

        private void cmdDataGridList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {

        }
    }
}
