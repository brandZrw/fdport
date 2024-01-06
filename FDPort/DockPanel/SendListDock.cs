using FDPort.Class;
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
    public partial class SendListDock : DockContent
    {
        public SendListDock()
        {
            InitializeComponent();
            TabText = "发送参数";
            CloseButton = false;
            CloseButtonVisible = false;
        }

        public void SendList_Change(int row, string value)
        {
            sendList.Rows[row].Cells[1].Value = value;
        }

        public void SendMap_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
            {
                KeyValuePair<string, FieldSendParam> pair = (KeyValuePair<string, FieldSendParam>)e.NewItems[0];
                sendList.Rows[e.NewStartingIndex].Cells[0].Value = pair.Key;
                sendList.Rows[e.NewStartingIndex].Cells[1].Value = pair.Value.ToString();
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                KeyValuePair<string, FieldSendParam> pair = (KeyValuePair<string, FieldSendParam>)e.NewItems[0];
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell textcell = new DataGridViewTextBoxCell();
                textcell.Value = pair.Key;
                row.Cells.Add(textcell);
                DataGridViewTextBoxCell textcell2 = new DataGridViewTextBoxCell();
                textcell2.Value = pair.Value.ToString();
                row.Cells.Add(textcell2);
                sendList.Rows.Add(row);
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                sendList.Rows.RemoveAt(e.OldStartingIndex);
            }
        }
        #region event
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Project.param.sendMap.CollectionChanged -= SendMap_CollectionChanged;
            try
            {
                if (e.ColumnIndex == 0) // 更改名称
                {
                    if (e.RowIndex >= Project.param.sendMap.Count)// 增加
                    {
                        string s = (string)sendList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        if (Project.param.sendMap.ContainsKey(s))
                        {
                            sendList.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            Project.param.sendMap.Add(s, new FieldSendParam("0"));
                        }
                    }
                    else // 更改
                    {
                        string key = Project.param.sendMap.ElementAt(e.RowIndex).Key;
                        string newKey = (string)sendList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        Dictionary<string, FieldSendParam> temp = Project.param.sendMap.ToDictionary(k => k.Key == key ? newKey : k.Key, k => k.Value);
                        Project.param.sendMap.Clear();
                        foreach (KeyValuePair<string, FieldSendParam> k in temp)
                        {
                            Project.param.sendMap.Add(k.Key, k.Value);
                        }
                    }
                }
                else if (e.ColumnIndex == 1) // 更改数值
                {
                    if (e.RowIndex >= Project.param.sendMap.Count)// 增加
                    {
                        Project.param.sendMap.Add(" ", new FieldSendParam((string)sendList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value));
                    }
                    else // 更改
                    {
                        string key = Project.param.sendMap.ElementAt(e.RowIndex).Key;
                        Project.param.sendMap[key].setStrValue((string)sendList.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue);
                    }
                }
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
            finally
            {
                Project.param.sendMap.CollectionChanged += SendMap_CollectionChanged;
            }

            //parse.cmd_send_upgrade();

        }

        private void sendList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Project.param.sendMap.CollectionChanged -= SendMap_CollectionChanged;
            if (e.RowIndex < Project.param.sendMap.Count)
            {
                string s = Project.param.sendMap.Keys.ElementAt(e.RowIndex);
                if (Project.param.sendMap.ContainsKey(s))
                {
                    Project.param.sendMap.Remove(s);
                }
            }
            Project.param.sendMap.CollectionChanged += SendMap_CollectionChanged;
        }
        private void sendList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right && e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                if ((sender as DataGridView).Rows[e.RowIndex].Selected == false)
                {
                    (sender as DataGridView).CurrentRow.Selected = false;
                    (sender as DataGridView).Rows[e.RowIndex].Selected = true;
                    (sender as DataGridView).CurrentCell = (sender as DataGridView).Rows[e.RowIndex].Cells[e.ColumnIndex];
                }
                if ((sender as DataGridView).SelectedRows.Count > 0)
                {
                    uiContextMenuStrip1.Show(MousePosition);
                }
            }
        }
        /*************sendlist******************/
        private void uiContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (sendList.SelectedRows[0].Index > -1)
            {
                十六进制ToolStripMenuItem1.Checked = Project.param.sendMap[(string)sendList.Rows[sendList.SelectedRows[0].Index].Cells[0].Value].isHex;
            }
        }

        private void 十六进制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (sendList.SelectedRows[0].Index > -1)
            {
                十六进制ToolStripMenuItem1.Checked = !十六进制ToolStripMenuItem1.Checked;
                sendList.Rows[sendList.SelectedRows[0].Index].Cells[1].Value = Project.param.sendMap[(string)sendList.Rows[sendList.SelectedRows[0].Index].Cells[0].Value].toHex(十六进制ToolStripMenuItem1.Checked);
            }
        }
        #endregion
    }
}
