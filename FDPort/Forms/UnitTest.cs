using FDPort.Class;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace FDPort.Forms
{
    public partial class UnitTest : MyForm<UartMore>
    {
        
        private ObservableCollection<UnitTestObject> unitTests;
        public UnitTest(ObservableCollection<UnitTestObject> lists)
        {
            InitializeComponent();
            unitTests = new ObservableCollection<UnitTestObject>();
            unitTests.CollectionChanged += UnitTests_CollectionChanged;
            foreach (UnitTestObject unitTest in lists)
            {
                unitTests.Add(unitTest);
            }
            fieldTest.DataSource = Project.param.sendMap.Keys.ToArray();
        }

        #region event
        /// <summary>
        /// 项目改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnitTests_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                UnitTestObject cmd = (UnitTestObject)e.NewItems[0];
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();
                textboxcell.Value = cmd.cmdName;
                row.Cells.Add(textboxcell);
                DataGridViewCheckBoxCell checkboxcell = new DataGridViewCheckBoxCell();
                checkboxcell.Value = cmd.enable;
                row.Cells.Add(checkboxcell);
                DataGridViewTextBoxCell textboxcel2 = new DataGridViewTextBoxCell();
                textboxcel2.Value = cmd.start.ToString();
                row.Cells.Add(textboxcel2);
                DataGridViewTextBoxCell textboxcel3 = new DataGridViewTextBoxCell();
                textboxcel3.Value = cmd.end.ToString();
                row.Cells.Add(textboxcel3);
                DataGridViewTextBoxCell textboxcel4 = new DataGridViewTextBoxCell();
                textboxcel4.Value = cmd.step.ToString();
                row.Cells.Add(textboxcel4);
                DataGridViewCheckBoxCell checkboxcel2 = new DataGridViewCheckBoxCell();
                checkboxcel2.Value = cmd.dec;
                row.Cells.Add(checkboxcel2);
                dataGridView1.Rows.Insert(e.NewStartingIndex, row);
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                dataGridView1.Rows.RemoveAt(e.OldStartingIndex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0 && e.RowIndex < unitTests.Count)
            {
                unitTests.RemoveAt(e.RowIndex);
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "enable" && e.RowIndex >= 0) //选定值
            {
                unitTests[e.RowIndex].enable = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "dec" && e.RowIndex >= 0)
            {
                unitTests[e.RowIndex].dec = (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "testName" && e.RowIndex >= 0 && e.RowIndex < unitTests.Count)
                {
                    unitTests[e.RowIndex].cmdName = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "start" && e.RowIndex >= 0)//选定值
                {
                    unitTests[e.RowIndex].start = (int)Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "end" && e.RowIndex >= 0)
                {
                    unitTests[e.RowIndex].end = (int)Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "step" && e.RowIndex >= 0)
                {
                    unitTests[e.RowIndex].step = (int)Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue);
                }
            }
            catch (Exception exp)
            {
                System.Windows.Forms.MessageBox.Show(exp.Message);
            }
        }

        private void EditAddBtn_Click(object sender, EventArgs e)
        {
            UnitTestObject cmd = new UnitTestObject();
            cmd.cmdName = fieldTest.Text;
            cmd.start = decimal.ToInt32(testStart.Value);
            cmd.end = decimal.ToInt32(testEnd.Value);
            cmd.step = decimal.ToInt32(testStep.Value);
            cmd.dec = decRadio.Checked;

            UnitTestObject x = unitTests.FirstOrDefault(t => t.cmdName.Equals(cmd.cmdName));
            if (x == null)
            {
                unitTests.Add(cmd);
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Project.param.unitTests = unitTests;
            Close();
        }
        #endregion
    }

    public class UnitTestObject
    {
        public int start { get; set; }
        public int end { get; set; }
        public int step { get; set; }
        public string cmdName { get; set; }
        public bool enable { get; set; }
        public bool dec { get; set; }

        public decimal cal(ref decimal t)
        {
            if (enable) // 单元测试使能
            {
                t = dec ? t - step : t + step;
                if (t > end)
                {
                    t = start;
                }
                else if (t < start)
                {
                    t = end;
                }
            }
            return t;
        }
    }
}
