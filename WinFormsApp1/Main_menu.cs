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
                if ((width >= 4 && height >= 4))
                {
                    GameField = new Game_Window(width, height);
                    GameField.Show();
                }
                else
                    Notify.Text = ("Enter correct" + "\r\n" + "field size");
            }
            catch
            {
                Notify.Text = ("Enter correct" + "\r\n" + "field size");
            }

        }

        private void Score_button_Click(object sender, EventArgs e)
        {
            Scores_list newForm = new ();
            newForm.Show();
        }
    }
}
