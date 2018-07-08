using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PacmanCOM377
{
    public partial class LoseDisplay : Form
    {
        public LoseDisplay()
        {
            InitializeComponent();


        }

        //restart button
        private void RestartButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        //

        //close application button
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        //try again button
        private void tryAgain_Click_1(object sender, EventArgs e)
        {

            Application.Restart();
    }
    }
}
