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
    public partial class Game_Window : Form
    {
        private int Width, Height;
        private int Curr_score, Best_score;
        private Button[,] Tiles;
        private int TILE_INTERVALS = 10;
        private Size NORMAL_TILE_SIZE = new Size(100, 100);
        private int BORDER_INTERVAL = 10;

        public Game_Window(int _Width, int _Height)
        {
            if (_Width < 2 || _Height < 2)
            {
                return;
            }
            Width = _Width;
            Height = _Height;
            InitializeComponent();
            GameField.Size = new Size(Width * (NORMAL_TILE_SIZE.Width + TILE_INTERVALS) + TILE_INTERVALS, Height * (NORMAL_TILE_SIZE.Height + TILE_INTERVALS) + TILE_INTERVALS);
            CreateField();
            this.Size = new Size(TILE_INTERVALS * 4 + GameField.Width, TILE_INTERVALS * 8 + GameField.Height + Restart_button.Height);
            GameField.Location = new Point(BORDER_INTERVAL, BORDER_INTERVAL * 2 + Restart_button.Height);

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

    }
}
