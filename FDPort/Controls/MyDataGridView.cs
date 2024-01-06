using FDPort.Class;
using FDPort.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDPort.Controls
{
    public class MyDataGridView: System.Windows.Forms.DataGridView
    {
        public ObservableCollection<FieldModule> items;
        public MyDataGridView(): base()
        {
            items = new ObservableCollection<FieldModule>();
            items.CollectionChanged += Items_CollectionChanged;//用这个，点击取消后再次进入页面，进入Items_CollectionChanged之后Rows会变成0
        }
        #region 拖拽
        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            base.OnDragEnter(drgevent);
            drgevent.Effect = DragDropEffects.Move;
        }
        protected override void OnCellMouseMove(DataGridViewCellMouseEventArgs e)
        {
            base.OnCellMouseMove(e);
            if ((e.Button == MouseButtons.Left))
            {
                //if ((e.ColumnIndex == -1) && (e.RowIndex > -1))
                DoDragDrop(Rows[e.RowIndex], DragDropEffects.Move);
            }
        }

        protected override void OnCellContentDoubleClick(DataGridViewCellEventArgs e)
        {
            base.OnCellContentDoubleClick(e);
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                CmdNew cmd = CmdNew.GetInstance(items.ElementAt(e.RowIndex), e.RowIndex);
                cmd.pageConfirm += pageConfirm;
                cmd.Show();
            }
        }

        int selectionIdx = 0;
        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            base.OnDragDrop(drgevent);
            int idx = GetRowFromPoint(drgevent.X, drgevent.Y);

            if (idx < 0)
            {
                return;
            }

            if (drgevent.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                DataGridViewRow row = (DataGridViewRow)drgevent.Data.GetData(typeof(DataGridViewRow));
                int seIndex = Rows.IndexOf(row);
                selectionIdx = idx;
                //Rows.Remove(row);
                //Rows.Insert(idx, row);
                if (items != null)
                {
                    FieldModule m = items.ElementAt(seIndex);
                    items.RemoveAt(seIndex);
                    items.Insert(selectionIdx, m);
                }
            }
        }

        private int GetRowFromPoint(int x, int y)
        {
            for (int i = 0; i < RowCount; i++)
            {
                Rectangle rec = GetRowDisplayRectangle(i, false);

                if (RectangleToScreen(rec).Contains(x, y))
                {
                    return i;
                }
            }

            return -1;
        }

        protected override void Dispose(bool disposing)
        {
            Rows.Clear();
            base.Dispose(disposing);
        }

        /// <summary>
        /// 保证row选中
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
        {
            base.OnRowsAdded(e);
            if (selectionIdx > -1)
            {
                Rows[selectionIdx].Selected = true;
                CurrentCell = Rows[selectionIdx].Cells[0];
            }
        }
        #endregion

        /// <summary>
        /// 设置items
        /// </summary>
        /// <param name="item"></param>
        public void SetItems(ObservableCollection<FieldModule> item)
        {
            foreach (FieldModule cmd in item)
            {
                items.Add(cmd);
            }
        }

        /// <summary>
        /// 删除项目
        /// </summary>
        /// <param name="e"></param>
        protected override void OnCellContentClick(DataGridViewCellEventArgs e)
        {
            base.OnCellContentClick(e);
            if (Columns[e.ColumnIndex].Name == "delete" && e.RowIndex >= 0 && e.RowIndex < items.Count)
            {
                items.RemoveAt(e.RowIndex);
            }
        }

        void pageConfirm(FieldModule cmd, int i, FieldModule.CM_Type t)
        {
            if (i == -1)
            {
                items.Add(cmd);
            }
            else
            {
                FieldModule temp = items.ElementAt(i);
                items.RemoveAt(i);
                items.Insert(i, cmd);
            }
        }

        public void CmdNewPage()
        {
            CmdNew cmd = CmdNew.GetInstance();
            cmd.pageConfirm += pageConfirm;
            cmd.Show();
        }

        public void CmdNewPage(int i)
        {
            CmdNew cmd = CmdNew.GetInstance(i);
            cmd.pageConfirm += pageConfirm;
            cmd.Show();
        }

        public void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add) // 新建的
            {
                if (e.NewItems.Count > 0)
                {
                    FieldModule cmd = (FieldModule)e.NewItems[0];
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = cmd.name;
                    row.Cells.Add(textboxcell);
                    DataGridViewTextBoxCell textboxcel2 = new DataGridViewTextBoxCell();
                    textboxcel2.Value = cmd.ToString();
                    row.Cells.Add(textboxcel2);
                    Rows.Insert(e.NewStartingIndex, row);
                }
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Rows.RemoveAt(e.OldStartingIndex);
            }
        }
    }
}
