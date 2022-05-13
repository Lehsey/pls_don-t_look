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
using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Main_menu : Form
    {
        private Game_Window GameField;
        public Main_menu()
        {
            InitializeComponent();
        }


        private void Start_button_Click(object sender, EventArgs e)
        {
            int width, height;
            try
            {
                width = Convert.ToInt32(Width_input.Text);
                height = Convert.ToInt32(Height_input.Text);
                GameField = new Game_Window(width, height);
                GameField.Show();

            }
            catch
            {

            }

        }

        private void Score_button_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = "NotePad.exe";
            ps.Arguments = "Scores_list.txt";
            p.StartInfo = ps;
            p.Start();
        }
    }
}
