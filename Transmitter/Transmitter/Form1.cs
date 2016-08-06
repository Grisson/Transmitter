using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transmitter
{
    public partial class Form1 : Form
    {
        // a constructor needed or not?
        private bool toggle1 = true;
        private bool toggle2 = true;
        private bool toggle3 = true;
        private bool toggle4 = true;

        public Form1()
        {
            InitializeComponent();
            SA.BackColor = Color.Green;
            SB.BackColor = Color.Green;
            SC.BackColor = Color.Green;
            SD.BackColor = Color.Green;
        }

        private void SA_Click(object sender, EventArgs e)
        {
            if (toggle1 == true)
            {
                SA.BackColor = Color.Red;
            }
            else
            {
                SA.BackColor = Color.Green;
            }
            toggle1 = !toggle1;
        }

        private void SB_Click(object sender, EventArgs e)
        {
            if (toggle2 == true)
            {
                SB.BackColor = Color.Red;
            }
            else
            {
                SB.BackColor = Color.Green;
            }
            toggle2 = !toggle2;
        }

        private void SC_Click(object sender, EventArgs e)
        {
            if (toggle3 == true)
            {
                SC.BackColor = Color.Red;
            }
            else
            {
                SC.BackColor = Color.Green;
            }
            toggle3 = !toggle3;
        }

        private void SD_Click(object sender, EventArgs e)
        {
            if (toggle4 == true)
            {
                SD.BackColor = Color.Red;
            }
            else
            {
                SD.BackColor = Color.Green;
            }
            toggle4 = !toggle4;
        }


    }
}
