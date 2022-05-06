using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Enter_button_Click(object sender, EventArgs e)
        {
            string name;
            name = Convert.ToString(Name_input.Text);
            StreamWriter f = new StreamWriter("Scores_list.txt");
            f.WriteLine(name);
        }
    }
}
