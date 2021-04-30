namespace Homework_6
{
    partial class Confirm
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
            this.Continue = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.detailsMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(132, 220);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(83, 23);
            this.Continue.TabIndex = 0;
            this.Continue.Text = "Yes, continue!";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(508, 220);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(78, 23);
            this.GoBack.TabIndex = 1;
            this.GoBack.Text = "No, go back!";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // detailsMessage
            // 
            this.detailsMessage.Location = new System.Drawing.Point(12, 12);
            this.detailsMessage.Multiline = true;
            this.detailsMessage.Name = "detailsMessage";
            this.detailsMessage.ReadOnly = true;
            this.detailsMessage.Size = new System.Drawing.Size(714, 202);
            this.detailsMessage.TabIndex = 2;
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 269);
            this.Controls.Add(this.detailsMessage);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.Continue);
            this.Name = "Confirm";
            this.Text = "Confirm";
            this.Load += new System.EventHandler(this.Confirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button GoBack;
        private System.Windows.Forms.TextBox detailsMessage;
    }
}