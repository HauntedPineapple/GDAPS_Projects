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
    public partial class Join : Form
    {
        //fields
        private Permission perm;
        private Confirm confirm;
        private LogIn login;
        public Random rng;
        //properties
        public CheckBox PermissionBox { get { return permissionBox; } }
        public TextBox Password { get { return inputPass; } }
        public TextBox Username { get { return inputUser; } }
        public TextBox InputName { get { return inputName; } }
        public int Age
        {
            get
            {
                int year = int.Parse(AgeDropDown.SelectedItem.ToString());
                DateTime today = DateTime.Now;
                return (today.Year - year);
            }
        }
        public bool Confirmed { get; set; }
        public bool LoggedIn { get; set; }
        //constructor
        public Join()
        {
            rng = new Random();
            InitializeComponent();
            perm = new Permission(this);
            login = new LogIn(this);
            confirm = new Confirm(this, perm);
        }

        // if the right conditions are met, continues to the confirmation menu
        private void JoinButton_Click(object sender, EventArgs e)
        {
            if (Age <= 20 && passwordmatchLabel.Visible == false && pangolinButton.Checked == true && permissionBox.Checked == true)
            {
                confirm.ShowDialog();
                if (Confirmed)
                {
                    //BSOD blueScreen = new BSOD();
                    //blueScreen.ShowDialog();
                    switch (rng.Next(0, 4))
                    {
                        case 0: System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=mbnBYh-BJ1g"); break;
                        case 1: System.Diagnostics.Process.Start("https://www.savepangolins.org/what-is-a-pangolin"); break;
                        case 2: System.Diagnostics.Process.Start("https://www.worldwildlife.org/species/pangolin"); break;
                        case 3: System.Diagnostics.Process.Start("https://www.worldwildlife.org/stories/what-is-a-pangolin"); break;
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Keep trying!", "", MessageBoxButtons.OKCancel);
                }
            }
            else
            {
                MessageBox.Show("Not all required conditions to create an account are met! Look back over your entered info and ensure everything is correct, then try again!", "OOOPS", MessageBoxButtons.YesNoCancel);
            }
        }

        private void LogBackIn_Click(object sender, EventArgs e)
        {
            login.ShowDialog();
            if (LoggedIn)
            {
                this.Close();
            }
        }

        // checks to see if the passwords "match"
        // in order to "match" they must have exactly opposite casings
        private void ConfirmInput_TextChanged(object sender, EventArgs e)
        {
            string firstPass = inputPass.Text;
            string secondPass = confirmInput.Text;

            if (firstPass == InvertCase(secondPass) && secondPass == InvertCase(firstPass))
            {
                passwordmatchLabel.Visible = false;
            }
            else
                passwordmatchLabel.Visible = true;
        }
        private void InputPass_TextChanged(object sender, EventArgs e)
        {
            string firstPass = inputPass.Text;
            string secondPass = confirmInput.Text;

            if (firstPass == InvertCase(secondPass) && secondPass == InvertCase(firstPass))
            {
                passwordmatchLabel.Visible = false;
            }
            else
                passwordmatchLabel.Visible = true;
        }

        private void AgeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = int.Parse(AgeDropDown.SelectedItem.ToString());
            if (year < 1999)
            {
                MessageBox.Show("You're too old to join Club Pangolin!", "OOPS", MessageBoxButtons.OK);
                inputUser.Text = "";
                inputPass.Text = "";
                confirmInput.Text = "";
                joinButton.Enabled = false;
            }
            if (pangolinButton.Checked)
            {
                if (Age <= 20)
                {
                    perm.ShowDialog();
                }
            }
        }

        // unless the pangolin option is selsected for gender
        // every time you try to input data into the username area
        // it forces you to type in the password box
        private void InputUser_TextChanged(object sender, EventArgs e)
        {
            if (!pangolinButton.Checked)
            {
                inputPass.Focus();
            }
        }

        // when the permission box is checked, allows the join button to be clicked
        private void PermissionBox_CheckedChanged(object sender, EventArgs e)
        {
            joinButton.Enabled = true;
        }

        /// <summary>
        /// switches the casings of all the letters in  a given string
        /// </summary>
        /// <param name="s">string to invert</param>
        /// <returns>inverted string</returns>
        private string InvertCase(string s)
        {
            char[] letters = s.ToCharArray();
            for (int a = 0; a < s.Length; a++)
            {
                //lower to capital
                if (s[a] >= 'a' && s[a] <= 'z')
                {
                    letters[a] = (char)(s[a] - 32);
                }
                //capital to lower
                else if (s[a] >= 'A' && s[a] <= 'Z')
                {
                    letters[a] = (char)(s[a] + 32);
                }
            }
            s = "";
            for (int a = 0; a < letters.Length; a++)
            {
                s = s + letters[a];
            }

            return s;
        }

        // Randomly changes the background color
        // and moves around the labels when they are hovered over
        private void Namelabel_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rng.Next(0, 256), rng.Next(0, 256), rng.Next(0, 256));
            namelabel.Location = new Point(rng.Next(0, this.Size.Width), rng.Next(0, this.Size.Height));
        }
        private void PassLabel_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rng.Next(0, 256), rng.Next(0, 256), rng.Next(0, 256));
            passLabel.Location = new Point(rng.Next(0, this.Size.Width), rng.Next(0, this.Size.Height));
        }
        private void ConfirmLabel_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rng.Next(0, 256), rng.Next(0, 256), rng.Next(0, 256));
            confirmLabel.Location = new Point(rng.Next(0, this.Size.Width), rng.Next(0, this.Size.Height));
        }
        private void UserLabel_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rng.Next(0, 256), rng.Next(0, 256), rng.Next(0, 256));
            userLabel.Location = new Point(rng.Next(0, this.Size.Width), rng.Next(0, this.Size.Height));
        }
        private void Agelabel_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(rng.Next(0, 256), rng.Next(0, 256), rng.Next(0, 256));
            agelabel.Location = new Point(rng.Next(0, this.Size.Width), rng.Next(0, this.Size.Height));
        }

        private void PressMe_Click(object sender, EventArgs e)
        {
            BSOD bluescreen = new BSOD();
            bluescreen.ShowDialog();
            this.Close();
        }
    }
}
