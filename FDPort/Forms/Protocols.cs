using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FDPort.Class;
using Newtonsoft.Json;

namespace FDPort.Forms
{
    public partial class Protocols : MyForm<Protocols>
    {

        public Protocols()
        {
            InitializeComponent();
            parsingList.Columns[0].Width = (int)(0.3 * parsingList.Width);
            parsingList.Columns[1].Width = (int)(0.4 * parsingList.Width);
            parsingList.Columns[2].Width = (int)(0.3 * parsingList.Width);

            foreach (CmdRecv cmd in Project.param.cmdRecv)
            {
                parsingList.Rows.Add(cmd.name, cmd.needReply, cmd.replyName);
            }
        }

        public System.Windows.Forms.DataGridView getParsingList()
        {
            return parsingList;
        }

        

        #region event
        private void parsingList_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (e.RowIndex < Project.param.cmdRecv.Count)
            {
                Project.param.cmdRecv.RemoveAt(e.RowIndex);
            }
        }
        void ItemChanged(int index, CmdRecv item)
        {
            if (index == -1)
            {
                parsingList.Rows.Add(item.name, item.needReply, item.replyName);
                Project.param.cmdRecv.Add(item);
            }
            else
            {
                Project.param.cmdRecv.RemoveAt(index);
                Project.param.cmdRecv.Insert(index, item);
                parsingList.Rows[index].Cells[0].Value = item.name;
                parsingList.Rows[index].Cells[1].Value = item.needReply;
                parsingList.Rows[index].Cells[2].Value = item.replyName;
            }
        }
        private void parsingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.RowIndex >= Project.param.cmdRecv.Count) // 新增
                {
                    CmdRecvStruct cmdStruct = CmdRecvStruct.GetInstance();
                    cmdStruct.itemChanged = new CmdRecvStruct.ItemChanged( ItemChanged);
                    cmdStruct.Show();
                }
                else
                {
                    CmdRecvStruct cmdStruct = CmdRecvStruct.GetInstance(e.RowIndex);
                    cmdStruct.itemChanged = new CmdRecvStruct.ItemChanged(ItemChanged);
                    cmdStruct.Show();
                }
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
        private void parsingList_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Control && e.KeyCode == Keys.C)
            {
                if (OpenClipboard(IntPtr.Zero))
                {
                    if (parsingList.SelectedRows.Count > 0)
                    {
                        SetClipboardData(CF_UNICODETEXT, Marshal.StringToHGlobalUni(JsonConvert.SerializeObject(Project.param.cmdRecv[parsingList.SelectedRows[0].Index])));

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
                        CmdRecv module = (CmdRecv)JsonConvert.DeserializeObject(ss, typeof(CmdRecv), setting);
                        Project.param.cmdRecv.Add(module);
                        parsingList.Rows.Add(module.name, module.needReply, module.replyName);
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
    }
}
