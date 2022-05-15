using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    // класс логики
    public class Logick
    {
        
        private int[,] Bloks; // массив значений таблицы
        private int Width, Height; // ширина и высота таблицы
        public int Common_value_gen = 2; // 90 %значение нового бока 
        private int Rare_value_gen = 4; // 10: значение нового блока
        public int Session_score = 0; // счёт текущей сессии


        public Logick(int _width, int _height)
        {
            Width = _width;
            Height = _height;
            // создание и заполнение догического массива
            Bloks = new int[Height, Width];
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Bloks[i, j] = 0;
                }
            }
            // генерация 2х начальных блоков
            Generate_new_blok();
            Generate_new_blok();
        }

        // возврат массива значений для передачи в граф. оболочку
        public int[,] Get_Bloks()
        {
            return Bloks;
        }

        // возврат счёта сессии для передачи в граф. оболочку
        public int GetScore()
        {
            return Session_score;
        }

        // метод генерации нового блока после хода
        private void Generate_new_blok()
        {
            System.Random rnd = new System.Random();
            int i, j;
            // выбор координат "нового" не нулевого блока
            i = rnd.Next(0, Height);
            j = rnd.Next(0, Width);
            while (Bloks[i, j] != 0)
            {
                i = rnd.Next(0, Height);
                j = rnd.Next(0, Width);
            }
            // присваивание нового значения нуджному блоку
            if (rnd.Next(0, 10) == 1)
            {
                Bloks[i,j] = Rare_value_gen;
            }
            else
            {
                Bloks[i,j] = Common_value_gen;
            }

        }

        // метод вызова нужного сдвина и последующей генерации нового значения если требуется
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

        // метод проверки на пустое (нулевое) значение в массиве
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

        // метод проверки можно ли ещё сделать ход
        public bool Game_over()
        {
            // проверка вохможных ходов всех тайлов кроме крайних правых и нижних
            for (int i = 0; i < Height - 1; i++)
            {
                for (int j = 0; j < Width - 1; j++)
                {
                    if ((Free_space()) | (Bloks[i,j] == Bloks[i + 1, j]) | (Bloks[i, j] == Bloks[i, j + 1]))
                    {
                        return false;
                    }
                }
            }
            // проверка возможжности ходов крайних правых тайлов
            for (int i = 0; i < Height - 1; i++)
            {
                if (Bloks[i, Width - 1] == Bloks[i + 1, Width - 1])
                {
                    return false;
                }
            }

            //проверка возможности ходов крайних нижних тайлов
            for (int i = 0; i < Width - 1; i++)
            {
                if (Bloks[Height - 1, i] == Bloks[Height - 1, i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        //метод поиск не нулевого значния в строчке
        private int find_val_in_line(int line, int start, bool reverse)
        {
            //поиск значения в порядке справа на лево
            if (reverse)
            {
                for (int i = start; i >= 0; i--)
                {
                    if (Bloks[line, i] != 0)
                    {
                        return i;
                    }
                }
                return -1; //все значения нулевые
            }
            else
            // в порядке слева на право
            {
                for (int i = start; i < Width; i++)
                {
                    if (Bloks[line, i] != 0)
                    {
                        return i;
                    }
                }
                return -1; // все значения нулевые
            }
        }

        // метод поиск нулевого значения в строке
        private int find_zero_in_line(int line, int start, bool reverse)
        {
            // в порядке справа на лево
            if (reverse)
            {
                for (int i = start; i >= 0; i--)
                {
                    if (Bloks[line, i] == 0)
                    {
                        return i;
                    }
                }
                return -1; // все начения не равны 0
            }
            else
            // в порядке слева на право
            {
                for (int i = start; i < Width; i++)
                {
                    if (Bloks[line, i] == 0)
                    {
                        return i;
                    }
                }
                return -1; // все значения не равны 0
            }
        }

        // поиск не нулевого значения в колонке
        private int find_val_in_col(int col, int start, bool reverse)
        {
            // снизу верх
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
            // сверху вниз
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

        // поиск нулевого значения в колонке
        private int find_zero_in_col(int col, int start, bool reverse)
        {
            if (reverse)
            // снизу вверх
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
            //сверху вниз
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

        // метод сдвига вверх
        private void move_up()
        {
            int old_pos; // позиция тайла текущего отсчёта
            int last_free_space; // позиция тайла ближайшего нулевого тайла относительно движения
            for (int j = 0; j < Width; j++)
            {
                old_pos = find_val_in_col(j, 0, false); // поиск позиции ненулевого тайла в текущей колонке
                for (int i = 0; i < Height; i++)
                {
                    // если такого нет - пропускаем колонку
                    if (old_pos == -1)
                    {
                        break;
                    }
                    // если координаты текущего тайла меньше или равны последнего ненулевого тайла, пропускаем 1 итерацию
                    if ((i == old_pos) | (i < old_pos))
                    {
                        continue;
                    }

                    if (Bloks[i, j] == Bloks[old_pos, j])
                    {
                        Bloks[old_pos, j] *= 2; // если текущий тайл равен последнему ненулевому тайлу то последний не нулевой тайл удваивается, а текущий обнуляется
                        Session_score += Bloks[old_pos, j];
                        Bloks[i, j] = 0;
                        old_pos = find_val_in_col(j, i, false); // обновление позиции последнего ненулевого тайла, поиск начинается с текущей позиции
                    }
                    else if ((Bloks[i, j] != Bloks[old_pos, j]) && (Bloks[i, j] != 0)) // если текущий тайл не равен 0 и не равне последнему не нулевому, текущий тайл становится последним не нулевым
                    {
                        old_pos = i;
                    }
                }
            }

            // Сдвиг колонки в нужную сторону в зависимости от стороны сдвига

            for (int j = 0; j < Width; j++)
            {
                last_free_space = find_zero_in_col(j, 0, false); // нахождение первой нулевой позхиции тайла 
                for(int i = 0; i < Height; i++)
                {
                    if (last_free_space == -1)
                    {
                        break; // если все тайлы не равны 0, то прерываем проверку
                    }

                    if ((Bloks[i, j] != 0) && (last_free_space < i)) // если текущий тайл не равен нулю, то он переносится на позицию нулевого тайла
                    {
                        Bloks[last_free_space, j] = Bloks[i, j];
                        Bloks[i, j] = 0;
                        last_free_space = find_zero_in_col(j, last_free_space, false); // поиск нового ненулевого тайла
                    }
                }
            }

        }

        // сдвиг вниз - аналогично сдвигу вверх, но реверсированно
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
        
        // Сдвиг в лево - аналогично свдигу вверх, но теперь обход идёт по строчкам а не колонкам
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

        // аналогично сдвигу влево, но реверсировано
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
