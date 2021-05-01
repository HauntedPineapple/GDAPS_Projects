namespace PE_MultipleForms
{
    partial class Parameters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parameters));
            this.startButton = new System.Windows.Forms.Button();
            this.LowEndLabel = new System.Windows.Forms.Label();
            this.HighEndLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.minInput = new System.Windows.Forms.TextBox();
            this.maxInput = new System.Windows.Forms.TextBox();
            this.timeInput = new System.Windows.Forms.TextBox();
            this.Info = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(14, 96);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(495, 102);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LowEndLabel
            // 
            this.LowEndLabel.AutoSize = true;
            this.LowEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowEndLabel.Location = new System.Drawing.Point(41, 28);
            this.LowEndLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LowEndLabel.Name = "LowEndLabel";
            this.LowEndLabel.Size = new System.Drawing.Size(69, 18);
            this.LowEndLabel.TabIndex = 1;
            this.LowEndLabel.Text = "Minimum";
            // 
            // HighEndLabel
            // 
            this.HighEndLabel.AutoSize = true;
            this.HighEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighEndLabel.Location = new System.Drawing.Point(220, 28);
            this.HighEndLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HighEndLabel.Name = "HighEndLabel";
            this.HighEndLabel.Size = new System.Drawing.Size(73, 18);
            this.HighEndLabel.TabIndex = 2;
            this.HighEndLabel.Text = "Maximum";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(419, 28);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(41, 18);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time";
            // 
            // minInput
            // 
            this.minInput.Location = new System.Drawing.Point(16, 66);
            this.minInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minInput.Name = "minInput";
            this.minInput.Size = new System.Drawing.Size(132, 22);
            this.minInput.TabIndex = 4;
            // 
            // maxInput
            // 
            this.maxInput.Location = new System.Drawing.Point(196, 66);
            this.maxInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maxInput.Name = "maxInput";
            this.maxInput.Size = new System.Drawing.Size(132, 22);
            this.maxInput.TabIndex = 5;
            // 
            // timeInput
            // 
            this.timeInput.Location = new System.Drawing.Point(377, 66);
            this.timeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.timeInput.Name = "timeInput";
            this.timeInput.Size = new System.Drawing.Size(132, 22);
            this.timeInput.TabIndex = 6;
            // 
            // Info
            // 
            this.Info.Enabled = false;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(14, 206);
            this.Info.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Info.Multiline = true;
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Size = new System.Drawing.Size(495, 115);
            this.Info.TabIndex = 7;
            this.Info.Text = resources.GetString("Info.Text");
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 334);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.timeInput);
            this.Controls.Add(this.maxInput);
            this.Controls.Add(this.minInput);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.HighEndLabel);
            this.Controls.Add(this.LowEndLabel);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Parameters";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label LowEndLabel;
        private System.Windows.Forms.Label HighEndLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox minInput;
        private System.Windows.Forms.TextBox maxInput;
        private System.Windows.Forms.TextBox timeInput;
        private System.Windows.Forms.TextBox Info;
    }
}

