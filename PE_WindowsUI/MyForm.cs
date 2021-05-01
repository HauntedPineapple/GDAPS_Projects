using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PE_WindowsUI
{
    class MyForm : Form
    {
        public MyForm()
        {
            this.Size = new Size(1000,1000);
            this.Text = "Hello World";

            ////making a button
            //Button firstButton = new Button();
            //firstButton.Location = new Point(10, 10);

            //// Add the button to the form's list of Controls
            //this.Controls.Add(firstButton);
            int count = 0;
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    count++;
                    Button tempButton = new Button();
                    tempButton.Location = new Point(b * 100, a * 100);
                    tempButton.Text = count.ToString();
                    this.Controls.Add(tempButton);

                    tempButton.MouseEnter += TempButton_MouseEnter;
                }
            }
        }

        private void TempButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button clicked = (Button)sender;
                Random rng = new Random();
                clicked.BackColor = Color.FromArgb(rng.Next());
            }
        }
    }
}
