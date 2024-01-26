using FDPort.Controls;
using FDPort.FieldModuleClass;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace FDPort.Forms
{
    public partial class CmdNew : MyForm<CmdNew>
    {
        List<FieldBaseControl> Cmds = new List<FieldBaseControl>();
        int index = -1;

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
