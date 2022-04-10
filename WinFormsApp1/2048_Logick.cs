﻿using System;
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

        public int[,] Get_Bloks()
        {
            return Bloks;
        }

        public int GetScore()
        {
            return Session_score;
        }
        private void Generate_new_blok()
        {
            System.Random rnd = new System.Random();
            int i, j;
            i = rnd.Next(0, Height - 1);
            j = rnd.Next(0, Width - 1);
            while (Bloks[i, j] != 0)
            {
                i = rnd.Next(0, Height - 1);
                j = rnd.Next(0, Width - 1);
            }

            if (rnd.Next(0, 10) == 1)
            {
                Bloks[i,j] = Rare_value_gen;
            }
            else
            {
                Bloks[i,j] = Common_value_gen;
            }

        }

        public void try_move(bool Up = false, bool Down = false, bool Left = false, bool Right = false)
        {
            if (Up)
            {
                move_up();
            }
            else if (Down)
            {
                move_down();
            }
            else if (Left)
            {
                move_left();
            }
            else if (Right)
            {
                move_right();
            }

            if (Free_space())
            {
                Generate_new_blok();
            }
        }

        private bool Free_space()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (Bloks[i, j] == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool Game_over()
        {
            for (int i = 0; i < Height - 1; i++)
            {
                for (int j = 0; j < Width - 1; j++)
                {
                    if ((Bloks[i,j] == Bloks[i, j + 1]) | (Bloks[i, j] == Bloks[i + 1, j]) | (Bloks[i, j] == 0) | (Bloks[i + 1, j] == 0) | (Bloks[i, j +1] == 0))
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        private void move_up()
        {
            for (int j = 0; j < Width; j++)
            {
                for (int i = 0; i < Height - 1; i++)
                {
                    if (Bloks[i + 1,j] == Bloks[i, j])
                    {
                        Bloks[i, j] *= 2;
                        Session_score += Bloks[i, j];
                        Bloks[i + 1, j] = 0;
                    }
                    else if (Bloks[i, j] == 0)
                    {
                        Bloks[i, j] = Bloks[i + 1, j];
                        Bloks[i + 1, j] = 0;
                    }
                }
            }
        }

        private void move_down()
        {
            for (int j = 0; j < Width ; j--)
            {
                for (int i = Height - 1; i > 0; i++)
                {
                    if (Bloks[i - 1, j] == Bloks[i, j])
                    {
                        Bloks[i, j] *= 2;
                        Session_score += Bloks[i, j];
                        Bloks[i - 1, j] = 0;
                    }
                    else if (Bloks[i, j] == 0)
                    {
                        Bloks[i, j] = Bloks[i - 1, j];
                        Bloks[i - 1, j] = 0;
                    }
                }
            }
        }

        private void move_left()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width - 1; j++)
                {
                    if (Bloks[i, j + 1] == Bloks [i, j])
                    {
                        Bloks[i, j] *= 2;
                        Bloks[i, j + 1] = 0;
                        Session_score += Bloks[i, j];
                    }
                    else if (Bloks[i, j] == 0)
                    {
                        Bloks[i, j] = Bloks[i, j + 1];
                        Bloks[i, j] = 0;
                    }
                }
            }
        }

        private void move_right()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = Width - 1; j > 0; j--)
                {
                    if (Bloks[i, j - 1] == Bloks[i, j])
                    {
                        Bloks[i, j] *= 2;
                        Bloks[i, j - 1] = 0;
                        Session_score += Bloks[i, j];
                    }
                    else if (Bloks[i, j] == 0)
                    {
                        Bloks[i, j] = Bloks[i, j - 1];
                        Bloks[i, j] = 0;
                    }
                }
            }
        }
    }
}
