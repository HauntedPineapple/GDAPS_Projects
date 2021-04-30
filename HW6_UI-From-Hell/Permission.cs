using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_6
{
    public partial class Permission : Form
    {
        private Join mainForm;
        public TextBox Email { get { return emailInput; } }

        public Permission(Join mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void EmailInput_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Caps lock is enabled!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MomOptiom_CheckedChanged(object sender, EventArgs e)
        {
            leave.Enabled = false;
        }
        private void DadOption_CheckedChanged(object sender, EventArgs e)
        {
            leave.Enabled = false;
        }
        private void PangOption1_CheckedChanged(object sender, EventArgs e)
        {
            leave.Enabled = true;
        }
        private void PangOption2_CheckedChanged(object sender, EventArgs e)
        {
            leave.Enabled = true;
        }

        private void Permission_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void Leave_Click(object sender, EventArgs e)
        {
            mainForm.PermissionBox.Checked = true;
            this.Hide();
        }

        private void PermissionLabel_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(mainForm.rng.Next(0, 256), mainForm.rng.Next(0, 256), mainForm.rng.Next(0, 256));
            permissionLabel.Location = new Point(mainForm.rng.Next(0, this.Size.Width), mainForm.rng.Next(0, this.Size.Height));

        }
    }
}
