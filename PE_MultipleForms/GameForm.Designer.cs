namespace PE_MultipleForms
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Output = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeLeft = new System.Windows.Forms.Label();
            this.guessInput = new System.Windows.Forms.TextBox();
            this.guess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(16, 181);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(695, 28);
            this.progressBar.TabIndex = 0;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(505, 84);
            this.Output.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(55, 20);
            this.Output.TabIndex = 1;
            this.Output.Text = "output";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input your guess";
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeft.Location = new System.Drawing.Point(313, 150);
            this.timeLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(84, 18);
            this.timeLeft.TabIndex = 3;
            this.timeLeft.Text = "Countdown";
            // 
            // guessInput
            // 
            this.guessInput.Location = new System.Drawing.Point(151, 7);
            this.guessInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guessInput.Name = "guessInput";
            this.guessInput.Size = new System.Drawing.Size(156, 22);
            this.guessInput.TabIndex = 4;
            this.guessInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GuessInput_KeyDown);
            // 
            // guess
            // 
            this.guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess.Location = new System.Drawing.Point(72, 52);
            this.guess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(133, 52);
            this.guess.TabIndex = 5;
            this.guess.Text = "Guess";
            this.guess.UseVisualStyleBackColor = true;
            this.guess.Click += new System.EventHandler(this.Guess_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 236);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.guessInput);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.progressBar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.TextBox guessInput;
        private System.Windows.Forms.Button guess;
    }
}