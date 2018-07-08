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
    public partial class WinDisplay : Form
    {
        public WinDisplay()
        {
            InitializeComponent();
            
        }
        //replay button
        private void replayButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //close application
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


            

            
        }


    }
