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
    public partial class Confirm : Form
    {
        private Join mainForm;
        private Permission permissionForm;

        public Confirm(Join mainForm, Permission permissionForm)
        {
            this.mainForm = mainForm;
            this.permissionForm = permissionForm;
            InitializeComponent();
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            detailsMessage.Text = "Are you sure you want to continue making an account with the following credentials?"
                                          +"\nUsername: "+mainForm.Username.Text
                                          +"\nPassword: "+mainForm.Password.Text
                                          +"\nParent's email: "+permissionForm.Email.Text
                                          +"\nAge: "+mainForm.Age
                                          +"\nName: "+mainForm.InputName.Text;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            mainForm.Confirmed = true;
            this.Close();
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            mainForm.Confirmed = false;
            this.Close();
        }
    }
}
