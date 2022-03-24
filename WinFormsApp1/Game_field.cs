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
        private int Common_value_gen = 2;
        private int Rare_value_gen = 4;
        private Button[,] Tiles;
        private int TILE_INTERVALS = 10;
        private Size NORMAL_TILE_SIZE = new Size(50, 50);
        private Size NORMAL_FORM_SIZE = new Size(300, 500);
        private int BORDER_INTERVAL = 10;
        private int a;

        public Game_Window(int _Width, int _Height)
        {
            if (_Width < 2 || _Height < 2)
            {
                return;
            }
            Width = _Width;
            Height = _Height;
            InitializeComponent();
            GameField.Size = new Size(Width * (NORMAL_TILE_SIZE.Width + TILE_INTERVALS), Height * (NORMAL_TILE_SIZE.Height + TILE_INTERVALS));
            GameField.Location = new Point(BORDER_INTERVAL, BORDER_INTERVAL);
            CreateField();


        }

        private void CreateField()
        {
            Tiles = CreateTiles(Width, Height);
        }
        private Button[,] CreateTiles(int tile_width_count, int tile_heght_count)
        {
            Button[,] field_tiles = new Button[Width, Height];
            for (int i = 0; i < tile_width_count; i++)
            {
                for(int j = 0; j < tile_width_count; j++)
                {
                    field_tiles[i, j] = new Button()
                    {
                        Size = NORMAL_FORM_SIZE
                    };
                }
            }


            return field_tiles;
        }

    }
}
