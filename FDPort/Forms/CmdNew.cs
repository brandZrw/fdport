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
using WeifenLuo.WinFormsUI.Docking;

namespace FDPort.Forms
{
    public partial class CmdNew : DockContent
    {
        List<FieldBaseControl> Cmds = new List<FieldBaseControl>();
        int index = -1;
        private static CmdNew instance;
        private static object _lock = new object();
        private FieldModule temp = null;
        public delegate void PageConfirm(FieldModule m, int index, FieldModule.CM_Type t);
        public PageConfirm pageConfirm;

        public CmdNew() : this(0)
        {
        }
        public CmdNew(int i)
        {
            InitializeComponent();

            Cmds.Add(cmdStatic1);
            Cmds.Add(cmdByte1);
            Cmds.Add(cmdBitControl1);
            Cmds.Add(cmdFuncControl1);
            Cmds.Add(cmdDataControl1);
            cmdTypeChoose.SelectedIndex = i;
        }

        public CmdNew(FieldModule field, int i)
        {
            InitializeComponent();

            Cmds.Add(cmdStatic1);
            Cmds.Add(cmdByte1);
            Cmds.Add(cmdBitControl1);
            Cmds.Add(cmdFuncControl1);
            Cmds.Add(cmdDataControl1);
            cmdName.Text = field.name;
            cmdTypeChoose.SelectedIndex = (int)field.type;
            Cmds[(int)field.type].SetModule(field);
            temp = field;
            index = i;

        }

        #region 一次窗口
        public static CmdNew GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                lock (_lock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new CmdNew();
                    }
                }
            }
            return instance;
        }
        public static CmdNew GetInstance(int i)
        {
            if (instance == null || instance.IsDisposed)
            {
                lock (_lock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new CmdNew(i);
                    }
                }
            }
            return instance;
        }

        public static CmdNew GetInstance(FieldModule field, int i)
        {
            if (instance == null || instance.IsDisposed)
            {
                lock (_lock)
                {
                    if (instance == null || instance.IsDisposed)
                    {
                        instance = new CmdNew(field,i);
                    }
                }
            }
            return instance;
        }
        #endregion

        #region event
        private void cmdTypeChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (FieldBaseControl control in Cmds)
            {
                control.Visible = false;
            }
            Cmds[cmdTypeChoose.SelectedIndex].Visible = true;
            if (cmdTypeChoose.SelectedIndex != 0 && cmdTypeChoose.SelectedIndex != 4)
            {
                cmdName.Visible = true;
                uiLabel1.Visible = true;
            }
            else
            {
                cmdName.Visible = false;
                uiLabel1.Visible = false;
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            try
            {
                if (cmdTypeChoose.SelectedIndex == 0 || cmdTypeChoose.SelectedIndex == 4)
                {
                    cmdName.Text = "";
                }
                pageConfirm?.Invoke(Cmds[cmdTypeChoose.SelectedIndex].GetModule(cmdName.Text), index, (FieldModule.CM_Type)cmdTypeChoose.SelectedIndex);
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

        private void CmdNew_Activated(object sender, EventArgs e)
        {
            cmdName.Focus();
        }
        #endregion
    }
}
