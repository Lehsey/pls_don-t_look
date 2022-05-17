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
    public partial class Scores_list : Form
    {
        public Scores_list()
        {
            InitializeComponent();
            foreach (var line in File.ReadLines("Scores_list.txt"))
            {
                var array = line.Split();
                dataGridView1.Rows.Add(array);
            }
        }
    }
}
