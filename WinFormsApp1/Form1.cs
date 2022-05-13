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
        private string score;
        public Form1(int _score)
        {
            score = Convert.ToString(_score);
            InitializeComponent();
        }

        private void Enter_button_Click(object sender, EventArgs e)
        {
            string name;
            name = Convert.ToString(Name_input.Text);
            File.AppendAllText("Scores_list.txt", name + " ");
            File.AppendAllText("Scores_list.txt", score);
            File.AppendAllText("Scores_list.txt", "\r\n");
            Close();
        }
    }
}
