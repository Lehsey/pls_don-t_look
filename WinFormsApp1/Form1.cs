using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public string name;
        public string score;
        public Form1(int _score)
        {
            score = Convert.ToString(_score);
            InitializeComponent();
        }
        private void Enter_button_Click(object sender, EventArgs e)
        {
            name = Convert.ToString(Name_input.Text);
            dataGridView1.Rows.Add(name, score);
        }
    }
}