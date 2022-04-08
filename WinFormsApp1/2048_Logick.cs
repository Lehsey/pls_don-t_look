using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Logick
    {
        private int[,] Bloks;
        private int Width, Height;
        private int Common_value_gen = 2;
        private int Rare_value_gen = 4;
        private int Session_score = 0;

        private Logick(int _width, int _height)
        {
            Width = _width;
            Height = _height;
            Bloks = new int[Width, Height];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Bloks[i, j] = 0;
                }
            }
            Generate_new_blok();
        }

        private void Generate_new_blok()
        {
            System.Random rnd = new System.Random();
            int i, j, value;
            i = rnd.Next(0, this.Height - 1);
            j = rnd.Next(0, this.Width - 1);
            while (this.Bloks[i, j] != 0)
            {
                i = rnd.Next(0, this.Height - 1);
                j = rnd.Next(0, this.Width - 1);
            }

            if (rnd.Next(0, 10) == 1)
            {
                this.Bloks[i,j] = this.Rare_value_gen;
            }
            else
            {
                this .Bloks[i,j] = this.Common_value_gen;
            }

        }

        public void move_up()
        {
            
        }




    }
}
