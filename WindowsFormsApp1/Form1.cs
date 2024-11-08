using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class johnPorksMansion : Form
    {
        int page = 1;
        public johnPorksMansion()
        {
            InitializeComponent();
            outputLabel.Text = "You are trapped in the basement of John Por's Mansion. How will you escape?";
            option1Button.Text = "Window";
            option2Button.Text = "Vent System";

        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 
            }
        }
    }
}
