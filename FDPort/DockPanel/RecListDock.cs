using FDPort.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace FDPort.DockPanel
{
    public partial class RecListDock : DockContent
    {
        public RecListDock()
        {
            InitializeComponent();
            TabText = "接收参数";
            CloseButton = false;
            CloseButtonVisible = false;
        }

        public void RecList_AddRow(KeyValuePair<string, FieldRecvParam> pair)
        {
            Project.param.showRecMap.Add(pair.Key);
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell textcell = new DataGridViewTextBoxCell();
            textcell.Value = pair.Key;
            row.Cells.Add(textcell);
            DataGridViewTextBoxCell textcell2 = new DataGridViewTextBoxCell();
            textcell2.Value = pair.Value.ShowValue();
            row.Cells.Add(textcell2);
            recList.Rows.Add(row);

        }
        #region event
        /*************reclist********************/
        private void uiContextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            if (recList.SelectedRows[0].Index > -1)
            {
                十六进制ToolStripMenuItem.Checked = Project.param.recvMap[(string)recList.Rows[recList.SelectedRows[0].Index].Cells[0].Value].isHex;
            }
        }

        private void 十六进制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (recList.SelectedRows[0].Index > -1)
            {
                十六进制ToolStripMenuItem.Checked = !十六进制ToolStripMenuItem.Checked;
                recList.Rows[recList.SelectedRows[0].Index].Cells[1].Value = Project.param.recvMap[(string)recList.Rows[recList.SelectedRows[0].Index].Cells[0].Value].ToHex(十六进制ToolStripMenuItem.Checked);
            }
        }


        private void recList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
                    uiContextMenuStrip2.Show(MousePosition);
                }
            }
        }
        private void recList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (e.RowIndex < Project.param.showRecMap.Count)
            {
                Project.param.showRecMap.Remove(Project.param.showRecMap.ElementAt(e.RowIndex));
            }
        }
        private void recList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)// 改数值
            {
                if(Project.param.recvMap.ContainsKey(Project.param.showRecMap.ElementAt(e.RowIndex)))
                {
                   if( Project.param.recvMap[Project.param.showRecMap.ElementAt(e.RowIndex)].objValue.GetType().Equals(typeof( string)))
                   {
                        MessageBox.Show("字符串类型无法设置曲线");
                        return;
                   }
                }
                if ((bool)recList.Rows[e.RowIndex].Cells[2].EditedFormattedValue == false)
                {
                    //选中改为不选中
                    if (Project.param.recvMap.ContainsKey(Project.param.showRecMap.ElementAt(e.RowIndex)))
                    {
                        FieldRecvParam m = Project.param.recvMap[Project.param.showRecMap.ElementAt(e.RowIndex)];
                        m.isShow = false;
                        // 删除曲线
                        Project.mainForm.chartDock.ChartDelSeries(Project.param.showRecMap.ElementAt(e.RowIndex));
                        Project.mainForm.chartDock.lineChart.Refresh();
                    }
                }
                else
                {
                    // 添加曲线
                    Project.mainForm.chartDock.ChartAddSeries(Project.param.showRecMap.ElementAt(e.RowIndex));
                    //不选中改为选中
                    FieldRecvParam m = Project.param.recvMap[Project.param.showRecMap.ElementAt(e.RowIndex)];
                    m.isShow = true;
                    SelectionChanged();
                }
            }
        }

        private void recList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 0) // 改名字
                {
                    if (e.RowIndex >= Project.param.showRecMap.Count)
                    {
                        object t = recList.Rows[e.RowIndex].Cells[0].Value;
                        string s;
                        if (t == null)
                        {
                            s = null;
                        }
                        else
                        {
                            s = t.ToString();
                        }

                        Project.param.showRecMap.Add(s);
                    }
                    else
                    {
                        Project.param.showRecMap[e.RowIndex] = (string)recList.Rows[e.RowIndex].Cells[0].Value;
                    }
                }
            }
        }

        private string lastSelectName="";
        public void SelectionChanged()
        {
            if (Project.mainForm.chartDock.plotData.ContainsKey(lastSelectName))
            {
                Project.mainForm.chartDock.plotData[lastSelectName].signalPlot.IsHighlighted = false;
            }
            if(recList.SelectedRows.Count>0)
            {
                string name = recList.SelectedRows[0].Cells[0].Value.ToString();
                if (Project.mainForm.chartDock.plotData.ContainsKey(name))
                {
                    Project.mainForm.chartDock.plotData[name].signalPlot.IsHighlighted = true;
                }
                lastSelectName = name;
            }
            
        }
        private void recList_SelectionChanged(object sender, EventArgs e)
        {
            SelectionChanged();
        }

        #endregion
    }
}
