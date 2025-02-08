using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace MegaDesk_Zach
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void widthInput_ValueChanged(object sender, EventArgs e)
        {
            // First add the min and max values in Desk.cs,
            // then come back here and add logic that checks the min and max values
            // then display a message if the input is valid. 
            // Also ensure it only accepts ints and not floats, doubles, or strings.\

            // Convert the NumericUpDown input from the user into an int, then assert that it is one.
            // CONVERT NUMupDOWN to INT!!!!!!!!!!

            try
            {
                int width = int.Parse(widthInput.Text);
                if (width < Desk.MIN_WIDTH || width > Desk.MAX_WIDTH)
                    MessageBox.Show("Keep this value between " + Desk.MIN_WIDTH + " and " + Desk.MAX_WIDTH + ".");
            }
            catch
            {
                MessageBox.Show(widthInput.Text + " is invalid");
            }
        }

        /*        private void widthInput_Validating(object sender, EventArgs e)
                {
                    try
                    {
                        int width = int.Parse(widthInput.Text);
                        if (width < Desk.MIN_WIDTH || width > Desk.MAX_WIDTH)
                            MessageBox.Show("Keep this value between " + Desk.MIN_WIDTH + " and " + Desk.MAX_WIDTH);
                    }
                    catch
                    {
                        MessageBox.Show(widthInput.Text + " is invalid");
                    }
                }  */


        private void depthInput_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int width = int.Parse(depthInput.Text);
                if (width < Desk.MIN_DEPTH || width > Desk.MAX_DEPTH)
                    MessageBox.Show("Keep this value between " + Desk.MIN_DEPTH + " and " + Desk.MAX_DEPTH + ".");
            }
            catch
            {
                MessageBox.Show(depthInput.Text + " is invalid");
            }
        }

        private void drawersInput_ValueChanged(object sender, EventArgs e)
        {
            try
            {
            int drawers = int.Parse(drawersInput.Text);
            if (drawers < Desk.MIN_DRAWERS || drawers > Desk.MAX_DRAWERS)
                MessageBox.Show("Keep this value between " + Desk.MIN_DRAWERS + " and " + Desk.MAX_DRAWERS + ".");
            }
            catch
            {
                MessageBox.Show(drawersInput.Text + " is invalid");
            }
        }

        private void desktopInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rushOrderInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void submitInputs_Click(object sender, EventArgs e)
        {
            Desk desk = new(int.Parse(widthInput.Text), int.Parse(depthInput.Text), int.Parse(drawersInput.Text), Enum.Parse<DesktopMaterial>(desktopInput.Text));
            DeskQuote deskQuote = new(nameInput.Text, int.Parse(rushOrderInput.Text.Substring(0, 2)), desk);
            DisplayQuote displayQuote = new(deskQuote);
            displayQuote.Show();
        }







        // IGNORE:
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

    }
}
