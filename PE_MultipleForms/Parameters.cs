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
    public partial class Parameters : Form
    {
        public Parameters()
        {
            InitializeComponent();

            minInput.Text = "0";
            maxInput.Text = "100";
            timeInput.Text = "120";
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                int low = int.Parse(minInput.Text);
                int high = int.Parse(maxInput.Text);
                int time = int.Parse(timeInput.Text);
                if (time < 0)
                {   // Ensures the time is greater than zero
                    MessageBox.Show("Invalid time input! Please use a POSITIVE whole number!",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
                // Make sure the low is less than the high
                if (low > high)
                {
                    MessageBox.Show("The minimum is lower than the maximum!",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }
                //There's at least 10 numbers between low and high
                if (high - low < 10)
                {
                    MessageBox.Show("There are less than 10 numbers between the minimum and the maximum!\nStop trying to play on easy mode.",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                GameForm game = new GameForm(low, high, time);
                game.ShowDialog();
            }
            catch (FormatException)
            {
                //Ensure all inputs are numbers
                MessageBox.Show("Incorrect input format! Please use whole NUMBERS only!",
                    "ERROR", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            catch (Exception caught)
            {
                MessageBox.Show(caught.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
