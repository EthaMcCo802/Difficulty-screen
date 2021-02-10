using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Difficulty_screen
{
   

    public partial class Form1 : Form
    {
        string mode;

        public Form1()
        {
            InitializeComponent();
            ; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void characterText_TextChanged(object sender, EventArgs e)
        {

        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Lime;
            mediumButton.BackColor = Color.Transparent;
            hardButton.BackColor = Color.Transparent;

            mode = "Easy";
            
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Transparent;
            mediumButton.BackColor = Color.Orange;
            hardButton.BackColor = Color.Transparent;

            mode = "Medium";
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Transparent;
            mediumButton.BackColor = Color.Transparent;
            hardButton.BackColor = Color.Red;

            mode = "Hard";
        }

        private void beginButton_Click(object sender, EventArgs e)
        {

            string name = nameBox.Text;

            outputLabel.Text = $"Your name is {name}";

            outputLabel.Text += $"\nYou have chosen {mode} difficulty";


        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
