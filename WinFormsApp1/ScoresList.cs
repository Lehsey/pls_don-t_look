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
    public partial class ScoresList : Form
    {
        public struct Player
        {
            public string name;
            public string score;

            public Player(string _name, string _score)
            {
                name = _name;
                score = _score;
            }
        }
        List<Player> players = new List<Player>();
        public ScoresList()
        {
            InitializeComponent();
        }
      
        private void ScoresList_Load(object sender, EventArgs e)
        {
            int i;
            players.Add(new Player(DataBank.name1, DataBank.score1));

            DataTable table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Score", typeof(string));

            for (i = 0; i < players.Count; i++)
            {
                table.Rows.Add(players[i].name, players[i].score);
            }
            dataGridView1.DataSource = table;

        }
    }
    public static class DataBank
    {
        public static string name1;
        public static string score1;
    }
}
