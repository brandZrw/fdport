using FDPort.Class;
using FDPort.FieldModuleClass;
using FDPort.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (OpenClipboard(IntPtr.Zero))
                {
                    if(SelectedRows.Count > 0)
                    {
                        SetClipboardData(CF_UNICODETEXT, Marshal.StringToHGlobalAnsi(JsonConvert.SerializeObject(items[SelectedRows[0].Index])));
                        string ss = Marshal.PtrToStringAnsi(GetClipboardData(CF_UNICODETEXT));
                        Console.WriteLine(ss);
                        
                    }
                    
                    CloseClipboard();
                }
            }
            else if(e.Control && e.KeyCode == Keys.V)
            {
                if (OpenClipboard(IntPtr.Zero))
                {
                    try
                    {
                        string ss = Marshal.PtrToStringAnsi(GetClipboardData(CF_UNICODETEXT));
                        var setting = new JsonSerializerSettings
                        {
                            Converters = new List<JsonConverter>
                        {
                            new JsonFieldModule()
                        }
                        };
                        FieldModule module = (FieldModule)JsonConvert.DeserializeObject(ss, typeof(FieldModule), setting);
                        items.Add(module);
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

        protected override void OnCellMouseDoubleClick(DataGridViewCellMouseEventArgs e)
        {
            base.OnCellMouseDoubleClick(e);
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                CmdNew cmd = CmdNew.GetInstance(items.ElementAt(e.RowIndex), e.RowIndex);
                cmd.pageConfirm = new CmdNew.PageConfirm( pageConfirm);
                cmd.Show();
            }
        }
        protected override void Dispose(bool disposing)
        {
            Rows.Clear();
            base.Dispose(disposing);
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

        public void CmdNewPage(params object[] i)
        {
            CmdNew cmd = CmdNew.GetInstance(i);
            cmd.pageConfirm = new CmdNew.PageConfirm( pageConfirm);
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

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // MyDataGridView
            // 
            this.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.RowTemplate.Height = 27;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
