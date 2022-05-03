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


        public Logick(int _width, int _height)
        {
            Width = _width;
            Height = _height;
            Bloks = new int[Height, Width];
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
            i = rnd.Next(0, Height);
            j = rnd.Next(0, Width);
            while (Bloks[i, j] != 0)
            {
                i = rnd.Next(0, Height);
                j = rnd.Next(0, Width);
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

        public bool Game_over()
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

        private int find_val_in_col(int col, int start)
        {
            for (int i = start; i < Height; i++)
            {
                if (Bloks[i, col] != 0)
                {
                    return i;
                }
            }
            return -1;
        }

        private int find_zero_in_col(int col, int start)
        {
            for (int i = start; i < Height; i++)
            {
                if (Bloks[i, col] == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        private void move_up()
        {
            int old_pos;
            int last_free_space;
            for (int j = 0; j < Width; j++)
            {
                old_pos = find_val_in_col(j, 0);
                for (int i = 0; i < Height; i++)
                {
                    if (old_pos == -1)
                    {
                        break;
                    }

                    if ((i == old_pos) | (i < old_pos))
                    {
                        continue;
                    }

                    if (Bloks[i, j] == Bloks[old_pos, j])
                    {
                        Bloks[old_pos, j] *= 2;
                        Session_score += Bloks[old_pos, j];
                        Bloks[i, j] = 0;
                        old_pos = find_val_in_col(j, i);
                    }
                    else if ((Bloks[i, j] != Bloks[old_pos, j]) && (Bloks[i, j] != 0))
                    {
                        old_pos = i;
                    }
                }
            }

            for (int j = 0; j < Width; j++)
            {
                last_free_space = find_zero_in_col(j, 0);
                for(int i = 0; i < Height; i++)
                {
                    if (last_free_space == -1)
                    {
                        break;
                    }

                    if ((Bloks[i, j] != 0) && (last_free_space < i))
                    {
                        Bloks[last_free_space, j] = Bloks[i, j];
                        Bloks[i, j] = 0;
                        last_free_space = find_zero_in_col(j, last_free_space);
                    }
                }
            }

        }

        private void move_down()
        {
            
        }

        private void move_left()
        {
            
        }

        private void move_right()
        {
          
        
        }
    }
}
