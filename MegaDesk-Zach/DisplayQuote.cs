using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Zach
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            totalLbl.Text = deskQuote.ToString();
            nameLbl.Text = deskQuote.CustomerName;
        }


        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
