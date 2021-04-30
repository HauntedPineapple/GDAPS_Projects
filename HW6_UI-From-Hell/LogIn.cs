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
    public partial class LogIn : Form
    {
        private Join mainForm;
        public LogIn(Join mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            InputName.Text = mainForm.Username.Text;
            InputPass.Text = mainForm.Password.Text;
        }

        private void Forgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Too bad", "haha", MessageBoxButtons.OK);
            this.Hide();
        }

        private void Log_Click(object sender, EventArgs e)
        {
            BSOD bluescreen = new BSOD();
            bluescreen.ShowDialog();
            mainForm.LoggedIn = true;
            this.Close();
        }

        private void InputPass_TextChanged(object sender, EventArgs e)
        {
            mainForm.Password.Text = this.InputPass.Text;
            log.Enabled = true;
        }

        private void InputName_TextChanged(object sender, EventArgs e)
        {
            mainForm.Username.Text = this.InputName.Text;
        }

        private void Help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=6_5PyOreBbo");
        }

        private void UserLabel_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(mainForm.rng.Next(0, 256), mainForm.rng.Next(0, 256), mainForm.rng.Next(0, 256));
            userLabel.Location = new Point(mainForm.rng.Next(0, this.Size.Width), mainForm.rng.Next(0, this.Size.Height));
        }
        private void PassLabel_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(mainForm.rng.Next(0, 256), mainForm.rng.Next(0, 256), mainForm.rng.Next(0, 256));
            passLabel.Location = new Point(mainForm.rng.Next(0, this.Size.Width), mainForm.rng.Next(0, this.Size.Height));
        }
    }
}
