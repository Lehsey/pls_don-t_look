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
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Game_Window : Form
    {
        private int Width, Height;
        private Button[,] Tiles;
        private int TILE_INTERVALS = 10;
        private Size DEFOULT_WINDOW_SIZE = new Size(500, 530);
        private Size NORMAL_TILE_SIZE = new Size(100, 100);
        private int BORDER_INTERVAL = 10;
        private int UP_BAR_SIZE = 40;
        private int Screen_height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
        private int Screen_width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        private Logick logick;
        private int Max_Session_score;

        public Game_Window(int _Width, int _Height)
        {
            if (_Width < 4 || _Height < 4)
            {
                return;
            }
            Width = _Width;
            Height = _Height;
            logick = new Logick(Width, Height);
            InitializeComponent();
            if (Screen_height - (Height * (NORMAL_TILE_SIZE.Height + TILE_INTERVALS) + TILE_INTERVALS) <= NORMAL_TILE_SIZE.Height + TILE_INTERVALS + BORDER_INTERVAL)
            {
                int new_sqr = (Screen_height - BORDER_INTERVAL * 6 - (TILE_INTERVALS * Height + 2) - Cur_score.Height) / Height;
                TILE_INTERVALS = 5;
                NORMAL_TILE_SIZE = new Size(new_sqr, new_sqr);
            }
            if (Screen_width - (Width * (NORMAL_TILE_SIZE.Width + TILE_INTERVALS) + TILE_INTERVALS) <= NORMAL_TILE_SIZE.Height + TILE_INTERVALS + BORDER_INTERVAL)
            {
                int new_sqr = (Screen_width - BORDER_INTERVAL * 2 - (TILE_INTERVALS * Width + 2)) / Width;
                TILE_INTERVALS = 5;
                NORMAL_TILE_SIZE = new Size(new_sqr, new_sqr);
            }
            GameField.Size = new Size(Width * (NORMAL_TILE_SIZE.Width + TILE_INTERVALS) + TILE_INTERVALS, Height * (NORMAL_TILE_SIZE.Height + TILE_INTERVALS) + TILE_INTERVALS);
            CreateField();
            this.Size = new Size(TILE_INTERVALS * 2 + GameField.Width + BORDER_INTERVAL*2, TILE_INTERVALS * 6 + GameField.Height + Restart_button.Height + UP_BAR_SIZE);
            GameField.Location = new Point(BORDER_INTERVAL, BORDER_INTERVAL * 2 + Restart_button.Height);
            this.KeyPreview = true;
            if(this.Size.Width < DEFOULT_WINDOW_SIZE.Width)
            {
                this.Size = new Size(DEFOULT_WINDOW_SIZE.Width, this.Size.Height);
            }
            MaxScoreOutput();
            UpdateField();
        }

        private void UpdateField()
        {

            int[,] logick_block = logick.Get_Bloks();
            Random random = new Random();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (logick_block[i, j] == 0)
                    {
                        Tiles[i, j].Text = "";
                        Tiles[i, j].BackColor = Color.WhiteSmoke;
                        Tiles[i, j].Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
                        continue;
                    }
                    else
                        Tiles[i, j].Text = logick_block[i, j].ToString();
                    Tiles[i, j].BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                    AdaptButtonFontSize(Tiles[i, j]);
                }
            }
        }


        private void Game_Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                logick.try_move(false, true, false, false);
            }
            else if (e.KeyCode == Keys.W)
            {
                logick.try_move(true, false, false, false);
            }
            else if (e.KeyCode == Keys.A)
            {
                logick.try_move(false, false, true, true);
            }
            else if (e.KeyCode == Keys.D)
            {
                logick.try_move(false, false, false, true);
            }
            UpdateField();
            ScoreOutput();
            GetMaxScore();
            Update();
            if (logick.Game_over() == true)
            {
                this.KeyPreview = false;
                Restart_button.Focus();
                GetMaxScore();
                Form1 newForm = new Form1(logick.GetScore());
                newForm.Show();
            }
        }

        private void Restart_button_Click(object sender, EventArgs e)
        {
            RestartField();
        }

        private void RestartField()
        {
            logick = new Logick(Width, Height);
            UpdateField();
            ScoreOutput();
            MaxScoreOutput();
            this.KeyPreview = true;

        }


        private void CreateField()
        {
            Point location = new Point(TILE_INTERVALS, TILE_INTERVALS);
            Tiles = CreateTiles(Width, Height);
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Tiles[i, j].Location = location;
                    Tiles[i, j].Name = "Tile" + i + j;
                    Tiles[i, j].Enabled = false;
                    this.GameField.Controls.Add(Tiles[i, j]);
                    location.X += TILE_INTERVALS + NORMAL_TILE_SIZE.Width;
                }
                location.X = TILE_INTERVALS;
                location.Y += TILE_INTERVALS + NORMAL_TILE_SIZE.Height;

            }

        }
        private Button[,] CreateTiles(int tile_width_count, int tile_height_count)
        {
            Button[,] field_tiles = new Button[Height, Width];
            for (int i = 0; i < tile_height_count; i++)
            {
                for (int j = 0; j < tile_width_count; j++)
                {
                    field_tiles[i, j] = new Button()
                    {
                        Size = NORMAL_TILE_SIZE,
                        Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold),
                        BackColor = Color.WhiteSmoke,
                    };
                }
            }


            return field_tiles;
        }

        private void ScoreOutput()
        {
            Cur_score.Text = Convert.ToString(logick.GetScore());
        }

        private void GetMaxScore()
        {
            Max_Session_score = Convert.ToInt32(Max_score.Text);
            if (logick.GetScore() > Max_Session_score)
                Max_Session_score = logick.GetScore();
            Max_score.Text = Convert.ToString(Max_Session_score);
            Settings.Default["MaxScore"] = Max_score.Text;
            Settings.Default.Save();
        }

        private void MaxScoreOutput()
        {
            Max_score.Text = Settings.Default["MaxScore"].ToString();
        }

        private void AdaptButtonFontSize(Button element, double fontSizePecrent = 0.85)
        {
            if (element == null) return;

            Size textSize;
            element.Font = new Font(element.Font.Name, 1, element.Font.Style);
            while ((textSize = TextRenderer.MeasureText(element.Text, element.Font)).Width < element.ClientSize.Width * fontSizePecrent)
            {
                element.Font = new Font(element.Font.Name, element.Font.Size + 0.5f, element.Font.Style);
            }
        }
    }
}