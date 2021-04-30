namespace Homework_6
{
    partial class Permission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permission));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.permissionLabel = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.leave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pangOption2 = new System.Windows.Forms.RadioButton();
            this.pangOption1 = new System.Windows.Forms.RadioButton();
            this.dadOption = new System.Windows.Forms.RadioButton();
            this.momOptiom = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // permissionLabel
            // 
            this.permissionLabel.AutoSize = true;
            this.permissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.permissionLabel.Location = new System.Drawing.Point(9, 9);
            this.permissionLabel.Name = "permissionLabel";
            this.permissionLabel.Size = new System.Drawing.Size(277, 16);
            this.permissionLabel.TabIndex = 1;
            this.permissionLabel.Text = "Have your parent enter their email here";
            this.permissionLabel.MouseEnter += new System.EventHandler(this.PermissionLabel_MouseEnter);
            // 
            // emailInput
            // 
            this.emailInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.emailInput.Location = new System.Drawing.Point(15, 42);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(238, 20);
            this.emailInput.TabIndex = 2;
            this.emailInput.TextChanged += new System.EventHandler(this.EmailInput_TextChanged);
            // 
            // leave
            // 
            this.leave.Enabled = false;
            this.leave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leave.Location = new System.Drawing.Point(66, 216);
            this.leave.Name = "leave";
            this.leave.Size = new System.Drawing.Size(124, 82);
            this.leave.TabIndex = 3;
            this.leave.Text = "OK";
            this.leave.UseVisualStyleBackColor = true;
            this.leave.Click += new System.EventHandler(this.Leave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pangOption2);
            this.groupBox1.Controls.Add(this.pangOption1);
            this.groupBox1.Controls.Add(this.dadOption);
            this.groupBox1.Controls.Add(this.momOptiom);
            this.groupBox1.Location = new System.Drawing.Point(32, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "I am:";
            // 
            // pangOption2
            // 
            this.pangOption2.AutoSize = true;
            this.pangOption2.Location = new System.Drawing.Point(89, 42);
            this.pangOption2.Name = "pangOption2";
            this.pangOption2.Size = new System.Drawing.Size(98, 17);
            this.pangOption2.TabIndex = 3;
            this.pangOption2.TabStop = true;
            this.pangOption2.Text = "Mama Pangolin";
            this.pangOption2.UseVisualStyleBackColor = true;
            this.pangOption2.CheckedChanged += new System.EventHandler(this.PangOption2_CheckedChanged);
            // 
            // pangOption1
            // 
            this.pangOption1.AutoSize = true;
            this.pangOption1.Location = new System.Drawing.Point(89, 19);
            this.pangOption1.Name = "pangOption1";
            this.pangOption1.Size = new System.Drawing.Size(94, 17);
            this.pangOption1.TabIndex = 2;
            this.pangOption1.TabStop = true;
            this.pangOption1.Text = "Papa Pangolin";
            this.pangOption1.UseVisualStyleBackColor = true;
            this.pangOption1.CheckedChanged += new System.EventHandler(this.PangOption1_CheckedChanged);
            // 
            // dadOption
            // 
            this.dadOption.AutoSize = true;
            this.dadOption.Location = new System.Drawing.Point(3, 42);
            this.dadOption.Name = "dadOption";
            this.dadOption.Size = new System.Drawing.Size(45, 17);
            this.dadOption.TabIndex = 1;
            this.dadOption.TabStop = true;
            this.dadOption.Text = "Dad";
            this.dadOption.UseVisualStyleBackColor = true;
            this.dadOption.CheckedChanged += new System.EventHandler(this.DadOption_CheckedChanged);
            // 
            // momOptiom
            // 
            this.momOptiom.AutoSize = true;
            this.momOptiom.Location = new System.Drawing.Point(3, 19);
            this.momOptiom.Name = "momOptiom";
            this.momOptiom.Size = new System.Drawing.Size(48, 17);
            this.momOptiom.TabIndex = 0;
            this.momOptiom.TabStop = true;
            this.momOptiom.Text = "Mom";
            this.momOptiom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.momOptiom.UseVisualStyleBackColor = true;
            this.momOptiom.CheckedChanged += new System.EventHandler(this.MomOptiom_CheckedChanged);
            // 
            // Permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 323);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.leave);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.permissionLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Permission";
            this.ShowIcon = false;
            this.Text = "Get your parent\'s permission!";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Permission_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label permissionLabel;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Button leave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pangOption2;
        private System.Windows.Forms.RadioButton pangOption1;
        private System.Windows.Forms.RadioButton dadOption;
        private System.Windows.Forms.RadioButton momOptiom;
    }
}