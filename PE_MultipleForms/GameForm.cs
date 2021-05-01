using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE_MultipleForms
{
    public partial class GameForm : Form
    {
        private Random rng;
        private int randomNumber;

        public GameForm(int low, int high, int time)
        {
            rng = new Random();
            randomNumber = rng.Next(low, high+1);

            InitializeComponent();

            guessInput.Text = "0";
            timer.Start();
            progressBar.Maximum = time;
        }

        private void Guess_Click(object sender, EventArgs e)
        {
            try
            {
                int input = int.Parse(guessInput.Text);
                if (input == randomNumber)
                {
                    Output.Text = "Winner!";
                    MessageBox.Show("You guessed the correct number!",
                    guessInput.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None);
                    this.Close();
                }
                else if (input < randomNumber)
                {
                    Output.Text = "Too low!";
                    guessInput.Text = "";
                }
                else if (input > randomNumber)
                {
                    Output.Text = "Too high!";
                    guessInput.Text = "";
                }
            }
            catch (FormatException)
            {
                //Ensure all inputs are numbers
                timer.Stop();
                MessageBox.Show("Incorrect input format! Please use whole NUMBERS only!",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < progressBar.Maximum)
            {
                progressBar.Value++;
            }
            if (progressBar.Value == progressBar.Maximum)
            {
                timer.Stop();
                guess.Enabled = false;
                guessInput.Enabled = false;
                MessageBox.Show("You failed to guess the correct number, the number was "+randomNumber, "FAIL", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void GuessInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Guess_Click(sender,e);
            }
        }
    }
}
