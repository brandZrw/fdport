using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FDPort.Class;
using FDPort.Forms;

namespace FDPort.Forms
{
    public partial class Protocols : System.Windows.Forms.Form
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

        #region 一次窗口
        private static Protocols instance;
        private static object _lock = new object();
        public static Protocols GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                lock (_lock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new Protocols();
                    }
                }
            }
            return instance;
        }
        #endregion

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
                    cmdStruct.itemChanged += ItemChanged;
                    cmdStruct.Show();
                }
                else
                {
                    CmdRecvStruct cmdStruct = CmdRecvStruct.GetInstance(e.RowIndex);
                    cmdStruct.itemChanged += ItemChanged;
                    cmdStruct.Show();
                }
            }
        }
        #endregion

    }
}
