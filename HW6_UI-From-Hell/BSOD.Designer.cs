namespace Homework_6
{
    partial class BSOD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BSOD));
            this.BlueScreen = new System.Windows.Forms.TextBox();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BlueScreen
            // 
            this.BlueScreen.BackColor = System.Drawing.SystemColors.Highlight;
            this.BlueScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BlueScreen.Font = new System.Drawing.Font("Lucida Console", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueScreen.ForeColor = System.Drawing.SystemColors.Window;
            this.BlueScreen.Location = new System.Drawing.Point(0, 0);
            this.BlueScreen.Margin = new System.Windows.Forms.Padding(2);
            this.BlueScreen.MaxLength = 0;
            this.BlueScreen.Multiline = true;
            this.BlueScreen.Name = "BlueScreen";
            this.BlueScreen.ReadOnly = true;
            this.BlueScreen.Size = new System.Drawing.Size(1125, 601);
            this.BlueScreen.TabIndex = 0;
            this.BlueScreen.TabStop = false;
            this.BlueScreen.Text = resources.GetString("BlueScreen.Text");
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ExitLabel.Location = new System.Drawing.Point(784, 396);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(112, 19);
            this.ExitLabel.TabIndex = 1;
            this.ExitLabel.Text = "Press me to exit";
            this.ExitLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // BSOD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(814, 487);
            this.ControlBox = false;
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.BlueScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BSOD";
            this.ShowIcon = false;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BSOD_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BlueScreen;
        private System.Windows.Forms.Label ExitLabel;
    }
}