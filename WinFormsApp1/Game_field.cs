﻿using System;
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
    public partial class Game_Window : Form
    {
        private int Width, Height;
        private Button[,] Tiles;
        private int TILE_INTERVALS = 10;
        private Size NORMAL_TILE_SIZE = new Size(100, 100);
        private int BORDER_INTERVAL = 10;
        private Logick logick;
        private int Max_Session_score = 0;


        public Game_Window(int _Width, int _Height)
        {
            if (_Width < 2 || _Height < 2)
            {
                return;
            }
            Width = _Width;
            Height = _Height;
            logick = new Logick(Width, Height);
            InitializeComponent();
            GameField.Size = new Size(Width * (NORMAL_TILE_SIZE.Width + TILE_INTERVALS) + TILE_INTERVALS, Height * (NORMAL_TILE_SIZE.Height + TILE_INTERVALS) + TILE_INTERVALS);
            CreateField();
            this.Size = new Size(TILE_INTERVALS * 4 + GameField.Width, TILE_INTERVALS * 8 + GameField.Height + Restart_button.Height);
            GameField.Location = new Point(BORDER_INTERVAL, BORDER_INTERVAL * 2 + Restart_button.Height);
            this.KeyPreview = true;
            UpdateField();

        }

        private void UpdateField()
        {
            int[,] logick_block = logick.Get_Bloks();
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (logick_block[i,j] == 0)
                    {
                        Tiles[i, j].Text = "";
                    }
                    else
                    {
                        Tiles[i, j].Text = logick_block[i, j].ToString();
                    }
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
            else if (e.KeyCode== Keys.D)
            {
                logick.try_move(false, false, false, true);
            }
            UpdateField();
            ScoreOutput();
            MaxScoreOutput();
            if (logick.Game_over() == true)
            {
                Form1 newForm = new Form1(logick.GetScore());
                newForm.Show();
                GetMaxScore();
            }
        }

        private void Restart_button_Click(object sender, EventArgs e)
        {
            
        }

        private void RestartField()
        {
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
                        Size = NORMAL_TILE_SIZE
                    };
                }
            }


            return field_tiles;
        }

        private void ScoreOutput()
        {
            string a = Convert.ToString(logick.GetScore());
            Cur_score.Text = a;
        }

        private void GetMaxScore()
        {
            int s = logick.Session_score;
            if (s > Max_Session_score)
            Max_Session_score = s;
            Max_score.Text = Convert.ToString(Max_Session_score);
            StreamWriter p = new StreamWriter("Max_score.txt");
            p.WriteLine(Max_score.Text);
            p.Close();

        }
        private void MaxScoreOutput()
        {
            StreamReader p = new StreamReader("Max_score.txt");
            Max_score.Text = p.ReadLine();
            p.Close();
        }
    }
}
