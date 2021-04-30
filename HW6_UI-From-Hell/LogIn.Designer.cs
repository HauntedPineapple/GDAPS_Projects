namespace Homework_6
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.InputName = new System.Windows.Forms.TextBox();
            this.InputPass = new System.Windows.Forms.TextBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.passLabel = new System.Windows.Forms.Label();
            this.forgot = new System.Windows.Forms.LinkLabel();
            this.log = new System.Windows.Forms.Button();
            this.pangoPic = new System.Windows.Forms.PictureBox();
            this.help = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pangoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // InputName
            // 
            this.InputName.Location = new System.Drawing.Point(116, 12);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(130, 20);
            this.InputName.TabIndex = 51;
            this.InputName.TextChanged += new System.EventHandler(this.InputName_TextChanged);
            // 
            // InputPass
            // 
            this.InputPass.Location = new System.Drawing.Point(116, 40);
            this.InputPass.Name = "InputPass";
            this.InputPass.Size = new System.Drawing.Size(130, 20);
            this.InputPass.TabIndex = 52;
            this.InputPass.TextChanged += new System.EventHandler(this.InputPass_TextChanged);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.Location = new System.Drawing.Point(2, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(101, 13);
            this.userLabel.TabIndex = 49;
            this.userLabel.Text = "Username or Email: ";
            this.userLabel.MouseEnter += new System.EventHandler(this.UserLabel_MouseEnter);
            // 
            // passLabel
            // 
            this.passLabel.AutoSize = true;
            this.passLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLabel.Location = new System.Drawing.Point(12, 41);
            this.passLabel.Name = "passLabel";
            this.passLabel.Size = new System.Drawing.Size(67, 15);
            this.passLabel.TabIndex = 50;
            this.passLabel.Text = "Password: ";
            this.passLabel.MouseEnter += new System.EventHandler(this.PassLabel_MouseEnter);
            // 
            // forgot
            // 
            this.forgot.AutoSize = true;
            this.forgot.Location = new System.Drawing.Point(26, 77);
            this.forgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(152, 13);
            this.forgot.TabIndex = 4;
            this.forgot.TabStop = true;
            this.forgot.Text = "Forgot username or password?";
            this.forgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Forgot_LinkClicked);
            // 
            // log
            // 
            this.log.Enabled = false;
            this.log.Location = new System.Drawing.Point(63, 136);
            this.log.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(124, 84);
            this.log.TabIndex = 5;
            this.log.Text = "Log In!";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.Log_Click);
            // 
            // pangoPic
            // 
            this.pangoPic.Image = ((System.Drawing.Image)(resources.GetObject("pangoPic.Image")));
            this.pangoPic.Location = new System.Drawing.Point(251, -10);
            this.pangoPic.Name = "pangoPic";
            this.pangoPic.Size = new System.Drawing.Size(303, 262);
            this.pangoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pangoPic.TabIndex = 53;
            this.pangoPic.TabStop = false;
            // 
            // help
            // 
            this.help.AutoSize = true;
            this.help.Location = new System.Drawing.Point(26, 102);
            this.help.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(110, 13);
            this.help.TabIndex = 54;
            this.help.TabStop = true;
            this.help.Text = "Need help logging in?";
            this.help.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Help_LinkClicked);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 233);
            this.Controls.Add(this.help);
            this.Controls.Add(this.pangoPic);
            this.Controls.Add(this.log);
            this.Controls.Add(this.forgot);
            this.Controls.Add(this.passLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.InputPass);
            this.Controls.Add(this.InputName);
            this.Name = "LogIn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pangoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.TextBox InputPass;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passLabel;
        private System.Windows.Forms.LinkLabel forgot;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.PictureBox pangoPic;
        private System.Windows.Forms.LinkLabel help;
    }
}