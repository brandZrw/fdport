using FDPort.Class;
using FDPort.Controls;
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
    public partial class CmdRecvStruct : Form
    {
        public CmdRecv item = new CmdRecv();
        private int index = -1;

        public delegate void ItemChanged(int index, CmdRecv item);
        public ItemChanged itemChanged;

        private void AddReply()
        {
            foreach (CmdSend cmd in Project.param.cmdSend)
            {
                replyCmd.Items.Add(cmd.name);
            }
        }
        public CmdRecvStruct()
        {
            InitializeComponent();
            cmdDataGridList.SetItems(item.list);
            AddReply();
        }


        public CmdRecvStruct(int index)
        {
            InitializeComponent();
            this.index = index;
            this.item = common.TransReflection(Project.param.cmdRecv.ElementAt(index));

            cmdDataGridList.SetItems(item.list);
            AddReply();
            autoReply.Checked = item.needReply;
            if (!string.IsNullOrEmpty(item.replyName))
            {
                replyCmd.SelectedItem = item.replyName;
            }

            CmdSendName.Text = item.name;
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
                item.replyName = (string)replyCmd.SelectedItem;
                item.needReply = autoReply.Checked;
                item.list = cmdDataGridList.items;
                itemChanged?.Invoke(index, item);
                // 重新加入recvMap
                foreach (FieldModule t in item.list)
                {
                    if (t.type != FieldModule.CM_Type.CM_STATIC && t.type != FieldModule.CM_Type.CM_DATA)
                    {
                        if (!Project.param.recvMap.ContainsKey(t.name))
                        {
                            KeyValuePair<string, FieldRecvParam> pair = new KeyValuePair<string, FieldRecvParam>(t.name, new FieldRecvParam());
                            Project.param.recvMap.Add(pair.Key, pair.Value);
                            if (t.type == FieldModule.CM_Type.CM_BYTE)
                            {
                                Project.param.recvMap[pair.Key].SetValueType(((FieldByte)t).byteType);
                                Project.mainForm.RecList_AddRow(pair);
                            }
                        }
                    }
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            finally
            {
                Close();
            }
        }

        private void CmdRecvStruct_KeyDown(object sender, KeyEventArgs e)
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
    }
}
