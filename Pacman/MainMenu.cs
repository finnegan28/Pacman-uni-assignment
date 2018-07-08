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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        //button to open the game
        private void StartGameBTN_Click(object sender, EventArgs e)
        {
            PacmanGUI LevelOne = new PacmanGUI();
            LevelOne.Show();
        }
    }
}
