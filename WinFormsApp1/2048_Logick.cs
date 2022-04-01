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

                }
            }
        }


    }
}
