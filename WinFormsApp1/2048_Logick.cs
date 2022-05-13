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
        public int Common_value_gen = 2;
        private int Rare_value_gen = 4;
        public int Session_score = 0;


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
                    if ((!Free_space()) && ((Bloks[i,j] != Bloks[i + 1, j]) && (Bloks[i, j] != Bloks[i, j + 1])) )
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private int find_val_in_line(int line, int start, bool reverse)
        {
            if (reverse)
            {
                for (int i = start; i >= 0; i--)
                {
                    if (Bloks[line, i] != 0)
                    {
                        return i;
                    }
                }
                return -1;
            }
            else
            {
                for (int i = start; i < Width; i++)
                {
                    if (Bloks[line, i] != 0)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }

        private int find_zero_in_line(int line, int start, bool reverse)
        {
            if (reverse)
            {
                for (int i = start; i >= 0; i--)
                {
                    if (Bloks[line, i] == 0)
                    {
                        return i;
                    }
                }
                return -1;
            }
            else
            {
                for (int i = start; i < Width; i++)
                {
                    if (Bloks[line, i] == 0)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
        private int find_val_in_col(int col, int start, bool reverse)
        {
            if (reverse)
            {
                for (int i = start; i >= 0; i--)
                {
                    if (Bloks[i, col] != 0)
                    {
                        return i;
                    }
                }
                return -1;
            }
            else
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
        }

        private int find_zero_in_col(int col, int start, bool reverse)
        {
            if (reverse)
            {
                for (int i = start; i >= 0; i--)
                {
                    if (Bloks[i, col] == 0)
                    {
                        return i;
                    }
                }
                return -1;
            }
            else
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
        }

        private void move_up()
        {
            int old_pos;
            int last_free_space;
            for (int j = 0; j < Width; j++)
            {
                old_pos = find_val_in_col(j, 0, false);
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
                        old_pos = find_val_in_col(j, i, false);
                    }
                    else if ((Bloks[i, j] != Bloks[old_pos, j]) && (Bloks[i, j] != 0))
                    {
                        old_pos = i;
                    }
                }
            }

            for (int j = 0; j < Width; j++)
            {
                last_free_space = find_zero_in_col(j, 0, false);
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
                        last_free_space = find_zero_in_col(j, last_free_space, false);
                    }
                }
            }

        }

        private void move_down()
        {
            int old_pos;
            int last_free_space;
            for (int j = 0; j < Width; j++)
            {
                old_pos = find_val_in_col(j, Height - 1, true);
                for (int i = Height - 1; i >= 0; i--)
                {
                    if (old_pos == -1)
                    {
                        break;
                    }
                    if ((i == old_pos) | (i > old_pos))
                    {
                        continue;
                    }
                    if (Bloks[i, j] == Bloks[old_pos, j])
                    {
                        Bloks[old_pos, j] *= 2;
                        Session_score += Bloks[old_pos, j];
                        Bloks[i, j] = 0;
                        old_pos = find_val_in_col(j, i, true);
                    }
                    else if ((Bloks[i, j] != Bloks[old_pos, j]) && (Bloks[i, j] != 0))
                    {
                        old_pos = i;
                    }
                }
            }

            for (int j = 0; j < Width; j++)
            {
                last_free_space = find_zero_in_col(j, Height - 1, true);
                for (int i = Height - 1; i >= 0; i--)
                {
                    if (last_free_space == -1)
                    {
                        break;
                    }

                    if ((Bloks[i, j] != 0) && (last_free_space > i))
                    {
                        Bloks[last_free_space, j] = Bloks[i, j];
                        Bloks[i, j] = 0;
                        last_free_space = find_zero_in_col(j, last_free_space, true);
                    }
                }
            }

        }

        private void move_left()
        {
            int old_pos;
            int last_free_space;
            for (int i = 0; i < Height; i++)
            {
                old_pos = find_val_in_line(i, 0, false);
                for (int j = 0; j < Width; j++)
                {
                    if (old_pos == -1)
                    {
                        break;
                    }

                    if ((j == old_pos) | (j < old_pos))
                    {
                        continue;
                    }

                    if (Bloks[i, j] == Bloks[i, old_pos])
                    {
                        Bloks[i, old_pos] *= 2;
                        Session_score += Bloks[i, old_pos];
                        Bloks[i, j] = 0;
                        old_pos = find_val_in_line(i, j, false);
                    }
                    else if ((Bloks[i, j] != Bloks[i, old_pos]) && (Bloks[i, j] != 0))
                    {
                        old_pos = j;
                    }
                }
            }

            for (int i = 0; i < Height; i++)
            {
                last_free_space = find_zero_in_line(i, 0, false);
                for (int j = 0; j < Width; j++)
                {
                    if (last_free_space == -1)
                    {
                        break;
                    }

                    if ((Bloks[i, j] != 0) && (last_free_space < j))
                    {
                        Bloks[i, last_free_space] = Bloks[i, j];
                        Bloks[i, j] = 0;
                        last_free_space = find_zero_in_line(i, last_free_space, false);
                    }
                }
            }
        }

        private void move_right()
        {
            int old_pos;
            int last_free_space;
            for (int i = 0; i < Height; i++)
            {
                old_pos = find_val_in_line(i, Width - 1, true);
                for (int j = Width - 1; j >= 0; j--)
                {
                    if (old_pos == -1)
                    {
                        break;
                    }

                    if ((j == old_pos) | (j > old_pos))
                    {
                        continue;
                    }

                    if (Bloks[i, j] == Bloks[i, old_pos])
                    {
                        Bloks[i, old_pos] *= 2;
                        Session_score += Bloks[i, old_pos];
                        Bloks[i, j] = 0;
                        old_pos = find_val_in_line(i, j, true);
                    }
                    else if ((Bloks[i, j] != Bloks[i, old_pos]) && (Bloks[i, j] != 0))
                    {
                        old_pos = j;
                    }
                }
            }

            for (int i = 0; i < Height; i++)
            {
                last_free_space = find_zero_in_line(i, Width - 1, true);
                for (int j = Width - 1; j >= 0; j--)
                {
                    if (last_free_space == -1)
                    {
                        break;
                    }

                    if ((Bloks[i, j] != 0) && (last_free_space > j))
                    {
                        Bloks[i, last_free_space] = Bloks[i, j];
                        Bloks[i, j] = 0;
                        last_free_space = find_zero_in_line(i, last_free_space, true);
                    }
                }
            }

        }
    }
}
