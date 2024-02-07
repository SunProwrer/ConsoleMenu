using System;
using System.Threading;
using Menu.MenuColors;
using Menu.MenuGet;

namespace Menu
{
    namespace MenuMas
    {
        public static class Massive
        {
            #region Вспомогательный функции

            /// <summary>
            /// Функция по нахождению максимальной длины 'рваного' массива
            /// </summary>
            /// <param name="mas">Входной массив</param>
            /// <returns>Возвращает длину максимальной строки</returns>
            static public int MaxLen(int[][] mas)
            {
                int kol = 0;

                foreach (int[] masin in mas)
                {
                    if (masin.Length > kol) kol = masin.Length;
                }

                return kol;
            }

            /// <summary>
            /// Функция по нахождению максимальной длины 'рваного' массива
            /// </summary>
            /// <param name="mas">Входной массив</param>
            /// <returns>Возвращает длину максимальной строки</returns>
            static public int MaxLen(char[][] mas)
            {
                int kol = 0;

                foreach (char[] masin in mas)
                {
                    if (masin.Length > kol) kol = masin.Length;
                }

                return kol;
            }

            #endregion

            #region LineMasesCreate

            /// <summary>
            /// Функция по созданию одномерного массива
            /// </summary>
            /// <param name="kol">Количество элементов в массиве</param>
            /// <returns>Возвращает пустой сформированный массив</returns>
            static public int[] CreateMas(int kol)
            {
                return new int[kol];
            }

            /// <summary>
            /// Функция по созданию одномерного массива символов
            /// </summary>
            /// <param name="kol">Количество элементов в массиве</param>
            /// <returns>Возвращает пустой сформированный массив символов</returns>
            static public char[] CreateMasChar(int kol)
            {
                return new char[kol];
            }

            #endregion

            #region TabMasesCreate

            /// <summary>
            /// Функция по созданию двумерного массива
            /// </summary>
            /// <param name="x">Количество столбцов (то, что в бок)</param>
            /// <param name="y">Количество строк (то, что вниз)</param>
            /// <returns>Возвращает пустой сформированный двумерный массив</returns>
            static public int[,] CreateMas(int x, int y)
            {
                return new int[x, y];
            }

            /// <summary>
            /// Функция по созданию двумерного массива символов
            /// </summary>
            /// <param name="x">Количество столбцов (то, что в бок)</param>
            /// <param name="y">Количество строк (то, что вниз)</param>
            /// <returns>Возвращает пустой сформированный двумерный массив символов</returns>
            static public char[,] CreateMasChar(int x, int y)
            {
                return new char[x, y];
            }

            #endregion

            #region StabMasesCreate

            /// <summary>
            /// Функция по созданию 'рваного' массива
            /// </summary>
            /// <param name="elements">Массив количества элементов массива</param>
            /// <returns>Возвращает пустой сформированный 'рваный' массив</returns>
            static public int[][] CreateMas(int[] elements)
            {
                int length = elements.Length, i = 0;
                int[][] mas = new int[length][];

                foreach (int kol in elements)
                {
                    mas[i] = new int[kol];

                    i++;
                }

                return mas;
            }

            /// <summary>
            /// Функция по созданию 'рваного' массива символов
            /// </summary>
            /// <param name="elements">Массив количества элементов массива</param>
            /// <returns>Возвращает пустой сформированный 'рваный' массив символов</returns>
            static public char[][] CreateMasChar(int[] elements)
            {
                int length = elements.Length, i = 0;
                char[][] mas = new char[length][];

                foreach (int kol in elements)
                {
                    mas[i] = new char[kol];

                    i++;
                }

                return mas;
            }

            #endregion

            #region PrintMasesLine

            /// <summary>
            /// Функция печати одномерного массива
            /// </summary>
            /// <param name="mas">Массив на печать</param>
            /// <param name="color">Цвет печати</param>
            static public void PrintMas(int[] mas, MenuColor.Color color = MenuColor.Color.Sky)
            {
                Console.WriteLine("Мавссив:");

                bool Masisformed = false;
                int len = 0;

                try
                {
                    len = mas.Length;

                    Masisformed = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Не создан");
                }

                if (Masisformed)
                {
                    if (len == 0) Console.WriteLine("Пустой");
                    else
                    {
                        MenuColor.SetColor(color);

                        for (int i = 0; i < len; i++)
                        {
                            Console.Write($"{i + 1,3}");
                        }

                        MenuColor.SetColor(MenuColor.Color.Classic);

                        Console.WriteLine();

                        foreach (int ele in mas)
                        {
                            Console.Write($"{ele,3}");
                        }

                        Console.WriteLine();
                    }
                }
            }

            /// <summary>
            /// Функция печати одномерного массива
            /// </summary>
            /// <param name="mas">Массив на печать</param>
            /// <param name="color">Цвет печати</param>
            static public void PrintMas(char[] mas, MenuColor.Color color = MenuColor.Color.Sky)
            {
                Console.WriteLine("Мавссив:");

                bool Masisformed = false;
                int len = 0;

                try
                {
                    len = mas.Length;

                    Masisformed = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Не создан");
                }

                if (Masisformed)
                {
                    if (len == 0) Console.WriteLine("Пустой");
                    else
                    {
                        MenuColor.SetColor(color);

                        for (int i = 0; i < len; i++)
                        {
                            Console.Write($"{i + 1,3}");
                        }

                        MenuColor.SetColor(MenuColor.Color.Classic);

                        Console.WriteLine();

                        foreach (char ele in mas)
                        {
                            Console.Write($"{ele,3}");
                        }

                        Console.WriteLine();
                    }
                }
            }

            #endregion

            #region PrintMasesTab

            /// <summary>
            /// Функция по печати двумерного массива
            /// </summary>
            /// <param name="mas">Массив на печать</param>
            /// <param name="color">Цвет печати</param>
            static public void PrintMas(int[,] mas, MenuColor.Color color = MenuColor.Color.Sky)
            {
                Console.WriteLine("Мавссив:");

                bool Masisformed = false;
                int lenx = 0, leny = 0;

                try
                {
                    lenx = mas.GetLength(0);
                    leny = mas.GetLength(1);

                    Masisformed = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Не создан");
                }

                if (Masisformed)
                {
                    if (lenx * leny == 0) Console.WriteLine("Пустой");
                    else
                    {
                        MenuColor.SetColor(color);

                        Console.Write(@" \ ");

                        for (int i = 0; i < leny; i++)
                        {
                            Console.Write($"{i + 1,3}");
                        }

                        MenuColor.SetColor(MenuColor.Color.Classic);

                        Console.WriteLine();

                        for (int i = 0; i < lenx; i++)
                        {
                            MenuColor.SetColor(color);

                            Console.Write($"{i + 1,2} ");

                            MenuColor.SetColor(MenuColor.Color.Classic);

                            for (int j = 0; j < leny; j++)
                            {
                                Console.Write($"{mas[i, j],3}");
                            }

                            Console.WriteLine();
                        }
                    }
                }
            }

            /// <summary>
            /// Функция по печати двумерного массива
            /// </summary>
            /// <param name="mas">Массив на печать</param>
            /// <param name="color">Цвет печати</param>
            static public void PrintMas(char[,] mas, MenuColor.Color color = MenuColor.Color.Sky)
            {
                Console.WriteLine("Мавссив:");

                bool Masisformed = false;
                int lenx = 0, leny = 0;

                try
                {
                    lenx = mas.GetLength(0);
                    leny = mas.GetLength(1);

                    Masisformed = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Не создан");
                }

                if (Masisformed)
                {
                    if (lenx * leny == 0) Console.WriteLine("Пустой");
                    else
                    {
                        MenuColor.SetColor(color);

                        Console.Write(@" \ ");

                        for (int i = 0; i < leny; i++)
                        {
                            Console.Write($"{i + 1,3}");
                        }

                        MenuColor.SetColor(MenuColor.Color.Classic);

                        Console.WriteLine();

                        for (int i = 0; i < lenx; i++)
                        {
                            MenuColor.SetColor(color);

                            Console.Write($"{i + 1,2} ");

                            MenuColor.SetColor(MenuColor.Color.Classic);

                            for (int j = 0; j < leny; j++)
                            {
                                Console.Write($"{mas[i, j],3}");
                            }

                            Console.WriteLine();
                        }
                    }
                }
            }

            #endregion

            #region PrintMasesStab

            /// <summary>
            /// Функция по печати 'рваного' массива
            /// </summary>
            /// <param name="mas">Массив на печать</param>
            /// <param name="color">Цвет печати</param>
            static public void PrintMas(int[][] mas, MenuColor.Color color = MenuColor.Color.Sky)
            {
                bool Masisformed = false;
                int lenx = 0, leny = 0;

                try
                {
                    lenx = mas.GetLength(0);
                    leny = MaxLen(mas);

                    Masisformed = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Не создан");
                }

                if (Masisformed)
                {
                    if (lenx * leny == 0) Console.WriteLine("Пустой");
                    else
                    {
                        MenuColor.SetColor(color);

                        Console.Write(@" \ ");

                        for (int i = 0; i < leny; i++)
                        {
                            Console.Write($"{i + 1,3}");
                        }

                        MenuColor.SetColor(MenuColor.Color.Classic);

                        Console.WriteLine();

                        int j = 1;

                        foreach (int[] masin in mas)
                        {
                            MenuColor.SetColor(color);

                            Console.Write($"{j,2} ");

                            MenuColor.SetColor(MenuColor.Color.Classic);

                            j++;

                            foreach (int ele in masin)
                            {
                                Console.Write($"{ele,3}");
                            }

                            Console.WriteLine();
                        }
                    }
                }
            }

            /// <summary>
            /// Функция по печати 'рваного' массива
            /// </summary>
            /// <param name="mas">Массив на печать</param>
            /// <param name="color">Цвет печати</param>
            static public void PrintMas(char[][] mas, MenuColor.Color color = MenuColor.Color.Sky)
            {
                bool Masisformed = false;
                int lenx = 0, leny = 0;

                try
                {
                    lenx = mas.GetLength(0);
                    leny = MaxLen(mas);

                    Masisformed = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Не создан");
                }

                if (Masisformed)
                {
                    if (lenx * leny == 0) Console.WriteLine("Пустой");
                    else
                    {
                        MenuColor.SetColor(color);

                        Console.Write(@" \ ");

                        for (int i = 0; i < leny; i++)
                        {
                            Console.Write($"{i + 1,3}");
                        }

                        MenuColor.SetColor(MenuColor.Color.Classic);

                        Console.WriteLine();

                        int j = 1;

                        foreach (char[] masin in mas)
                        {
                            MenuColor.SetColor(color);

                            Console.Write($"{j,2} ");

                            MenuColor.SetColor(MenuColor.Color.Classic);

                            j++;

                            foreach (char ele in masin)
                            {
                                Console.Write($"{ele,3}");
                            }

                            Console.WriteLine();
                        }
                    }
                }
            }

            #endregion

            #region ReadMasesLine

            /// <summary>
            /// Функция по ручному заполнению одномерного массива
            /// </summary>
            /// <param name="mas">Возвращает заполненный массив</param>
            /// <param name="min">Минимум вводимого числа</param>
            /// <param name="max">Максимум вводимого числа</param>
            static public void ReadMas(ref int[] mas, int min = -10, int max = 10)
            {
                int len = mas.Length;

                for (int i = 0; i < len; i++)
                {
                    Console.Clear();

                    PrintEleMas(mas, i);

                    mas[i] = Get.Int("Введите число", min, max);
                }
            }

            /// <summary>
            /// Функция по печати массива для заполнения
            /// </summary>
            /// <param name="mas">Массив на печать</param>
            /// <param name="pos">Позиция заполнения</param>
            /// <param name="color">Цвет печати рамки</param>
            static private void PrintEleMas(int[] mas, int pos = 0, MenuColor.Color color = MenuColor.Color.Sky)
            {
                int len = mas.Length;

                MenuColor.SetColor(color);

                for (int i = 1; i <= len; i++)
                {
                    Console.Write($"{i,2} ");
                }

                MenuColor.SetColor(MenuColor.Color.Classic);

                Console.WriteLine();

                for (int i = 0; i < pos; i++)
                {
                    Console.Write($"{mas[i],2} ");
                }

                MenuColor.ReverseColor();

                Console.WriteLine($"{"-",2} ");

                MenuColor.ReverseColor();
            }

            /// <summary>
            /// Функция по ручному заполнению одномерного массива символов
            /// </summary>
            /// <param name="mas">Возвращает заполненный массив символов</param>
            static public void ReadMas(ref char[] mas)
            {
                int len = mas.Length;

                for (int i = 0; i < len; i++)
                {
                    Console.Clear();

                    PrintEleMas(mas, i);

                    do
                    {
                        Console.Write($"Введите символ: ");
                    }
                    while (!char.TryParse(Console.ReadLine(), out mas[i]));
                }
            }

            /// <summary>
            /// Функция по печати массива для заполнения
            /// </summary>
            /// <param name="mas">Массив на печать</param>
            /// <param name="pos">Позиция заполнения</param>
            /// <param name="color">Цвет печати рамки</param>
            static private void PrintEleMas(char[] mas, int pos = 0, MenuColor.Color color = MenuColor.Color.Sky)
            {
                int len = mas.Length;

                MenuColor.SetColor(color);

                for (int i = 1; i <= len; i++)
                {
                    Console.Write($"{i,2} ");
                }

                MenuColor.SetColor(MenuColor.Color.Classic);

                Console.WriteLine();

                for (int i = 0; i < pos; i++)
                {
                    Console.Write($"{mas[i],2} ");
                }

                MenuColor.ReverseColor();

                Console.WriteLine($"{"-",2} ");

                MenuColor.ReverseColor();
            }

            #endregion

            #region ReadMasesTab

            /// <summary>
            /// Функция по ручному заполнению двумерного массива
            /// </summary>
            /// <param name="mas">Возвращает заполненный массив</param>
            /// <param name="min">Минимум вводимого числа</param>
            /// <param name="max">Максимум вводимого числа</param>
            static public void ReadMas(ref int[,] mas, int min = -10, int max = 10)
            {
                int
                    lenx = mas.GetLength(0),
                    leny = mas.GetLength(1);

                for (int i = 0; i < lenx; i++)
                {
                    for (int j = 0; j < leny; j++)
                    {
                        Console.Clear();

                        PrintEleMas(mas, i, j);

                        mas[i, j] = Get.Int("Введте число", min, max);
                    }
                }
            }

            /// <summary>
            /// Функция по печати массива для заполнения
            /// </summary>
            /// <param name="mas">Массив на печать</param>
            /// <param name="posx">Позиция заполнения (вниз)</param>
            /// <param name="posy">Позиция заполнения (в бок)</param>
            /// <param name="color">Цвет печати рамки</param>
            static private void PrintEleMas(int[,] mas, int posx = 0, int posy = 0, MenuColor.Color color = MenuColor.Color.Sky)
            {
                int
                    lenx = mas.GetLength(0),
                    leny = mas.GetLength(1),
                    position = 0;

                MenuColor.SetColor(color);

                Console.Write(@" \ ");

                for (int i = 0; i < leny; i++)
                {
                    Console.Write($"{i + 1,3}");
                }

                MenuColor.SetColor(MenuColor.Color.Classic);

                Console.WriteLine();
                
                for (int i = 0; i < posx; i++)
                {
                    position = i + 1;

                    MenuColor.SetColor(color);

                    Console.Write($"{i + 1,2} ");

                    MenuColor.SetColor(MenuColor.Color.Classic);

                    for (int j = 0; j < leny; j++)
                    {
                        Console.Write($"{mas[i, j],3}");
                    }

                    Console.WriteLine();
                }

                MenuColor.SetColor(color);

                Console.Write($"{position + 1,2} ");

                MenuColor.SetColor(MenuColor.Color.Classic);

                for (int i = 0; i < posy; i++)
                {
                    Console.Write($"{mas[position, i],3}");
                }

                MenuColor.ReverseColor();

                Console.Write($" - ");

                MenuColor.ReverseColor();

                Console.WriteLine();

                MenuColor.SetColor(color);

                for (int i = position + 1; i < lenx; i++)
                {
                    Console.WriteLine($"{i + 1,2} ");
                }

                MenuColor.SetColor(MenuColor.Color.Classic);
            }

            /// <summary>
            /// Функция по ручному заполнению двумерного массива символов
            /// </summary>
            /// <param name="mas">Возвращает заполненный массив</param>
            static public void ReadMas(ref char[,] mas)
            {
                int
                    lenx = mas.GetLength(0),
                    leny = mas.GetLength(1);

                Console.WriteLine($"Вводите символы");

                for (int i = 0; i < lenx; i++)
                {
                    for (int j = 0; j < leny; j++)
                    {
                        Console.Clear();

                        PrintEleMas(mas, i, j);

                        mas[i, j] = Get.Char("Введте символ");
                    }
                }
            }

            /// <summary>
            /// Функция по печати массива для заполнения
            /// </summary>
            /// <param name="mas">Массив на печать</param>
            /// <param name="posx">Позиция заполнения (вниз)</param>
            /// <param name="posy">Позиция заполнения (в бок)</param>
            /// <param name="color">Цвет печати рамки</param>
            static private void PrintEleMas(char[,] mas, int posx = 0, int posy = 0, MenuColor.Color color = MenuColor.Color.Sky)
            {
                int
                    lenx = mas.GetLength(0),
                    leny = mas.GetLength(1),
                    position = 0;

                MenuColor.SetColor(color);

                Console.Write(@" \ ");

                for (int i = 0; i < leny; i++)
                {
                    Console.Write($"{i + 1,3}");
                }

                MenuColor.SetColor(MenuColor.Color.Classic);

                Console.WriteLine();

                for (int i = 0; i < posx; i++)
                {
                    position = i + 1;

                    MenuColor.SetColor(color);

                    Console.Write($"{i + 1,2} ");

                    MenuColor.SetColor(MenuColor.Color.Classic);

                    for (int j = 0; j < leny; j++)
                    {
                        Console.Write($"{mas[i, j],3}");
                    }

                    Console.WriteLine();
                }

                MenuColor.SetColor(color);

                Console.Write($"{position + 1,2} ");

                MenuColor.SetColor(MenuColor.Color.Classic);

                for (int i = 0; i < posy; i++)
                {
                    Console.Write($"{mas[position, i],3}");
                }

                MenuColor.ReverseColor();

                Console.Write($" - ");

                MenuColor.ReverseColor();

                Console.WriteLine();

                MenuColor.SetColor(color);

                for (int i = position + 1; i < lenx; i++)
                {
                    Console.WriteLine($"{i + 1,2} ");
                }

                MenuColor.SetColor(MenuColor.Color.Classic);
            }

            #endregion

            #region ReadMasesStab

            /// <summary>
            /// Функция по ручному заполнению 'рваного' массива
            /// </summary>
            /// <param name="mas">Возвращает заполненный массив</param>
            /// <param name="min">Минимум вводимого числа</param>
            /// <param name="max">Максимум вводимого числа</param>
            static public void ReadMas(ref int[][] mas, int min = -10, int max = 10)
            {
                Console.WriteLine($"Вводите целые числа");

                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < mas[i].Length; j++)
                    {
                        Console.Clear();

                        PrintEleMas(mas, i, j);

                        mas[i][j] = Get.Int("Введите число", min, max);
                    }
                }
            }

            /// <summary>
            /// Функция по печати массива для заполнения
            /// </summary>
            /// <param name="mas">Массив на печать</param>
            /// <param name="pos">Позиция заполнения</param>
            /// <param name="color">Цвет печати рамки</param>
            static private void PrintEleMas(int[][] mas, int posx = 0, int posy = 0, MenuColor.Color color = MenuColor.Color.Sky)
            {
                int
                    lenx = mas.GetLength(0),
                    leny = MaxLen(mas),
                    position = 0;
                int[] prommas;

                MenuColor.SetColor(color);

                Console.Write(@" \ ");

                for (int i = 0; i < leny; i++)
                {
                    Console.Write($"{i + 1,3}");
                }

                MenuColor.SetColor(MenuColor.Color.Classic);

                Console.WriteLine();

                for (int i = 0; i < posx; i++)
                {
                    prommas = mas[i];

                    position = i + 1;

                    MenuColor.SetColor(color);

                    Console.Write($"{i + 1,2} ");

                    MenuColor.SetColor(MenuColor.Color.Classic);

                    foreach (int ele in prommas)
                    {
                        Console.Write($"{ele,3}");
                    }

                    Console.WriteLine();
                }

                MenuColor.SetColor(color);

                Console.Write($"{position + 1,2} ");

                MenuColor.SetColor(MenuColor.Color.Classic);

                prommas = mas[position];

                for (int j = 0; j < posy; j++)
                {
                    Console.Write($"{prommas[j],3}");
                }

                MenuColor.ReverseColor();

                Console.WriteLine(" - ");

                MenuColor.SetColor(color);

                for (int i = position + 1; i < lenx; i++)
                {
                    Console.WriteLine($"{i + 1,2} ");
                }

                MenuColor.SetColor(MenuColor.Color.Classic);
            }

            /// <summary>
            /// Функция по ручному заполнению 'рваного' массива символов
            /// </summary>
            /// <param name="mas">Возвращает заполненный массив</param>
            static public void ReadMas(ref char[][] mas)
            {
                Console.WriteLine($"Вводите символы");

                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < mas[i].Length; j++)
                    {
                        Console.Clear();

                        PrintEleMas(mas, i, j);

                        mas[i][j] = Get.Char("Введите символ");
                    }
                }
            }

            /// <summary>
            /// Функция по печати массива для заполнения
            /// </summary>
            /// <param name="mas">Массив на печать</param>
            /// <param name="pos">Позиция заполнения</param>
            /// <param name="color">Цвет печати рамки</param>
            static private void PrintEleMas(char[][] mas, int posx = 0, int posy = 0, MenuColor.Color color = MenuColor.Color.Sky)
            {
                int
                    lenx = mas.GetLength(0),
                    leny = MaxLen(mas),
                    position = 0;
                char[] prommas;

                MenuColor.SetColor(color);

                Console.Write(@" \ ");

                for (int i = 0; i < leny; i++)
                {
                    Console.Write($"{i + 1,3}");
                }

                MenuColor.SetColor(MenuColor.Color.Classic);

                Console.WriteLine();

                for (int i = 0; i < posx; i++)
                {
                    prommas = mas[i];

                    position = i + 1;

                    MenuColor.SetColor(color);

                    Console.Write($"{i + 1,2} ");

                    MenuColor.SetColor(MenuColor.Color.Classic);

                    foreach (char ele in prommas)
                    {
                        Console.Write($"{ele,3}");
                    }

                    Console.WriteLine();
                }

                MenuColor.SetColor(color);

                Console.Write($"{position + 1,2} ");

                MenuColor.SetColor(MenuColor.Color.Classic);

                prommas = mas[position];

                for (int j = 0; j < posy; j++)
                {
                    Console.Write($"{prommas[j],3}");
                }

                MenuColor.ReverseColor();

                Console.WriteLine(" - ");

                MenuColor.SetColor(color);

                for (int i = position + 1; i < lenx; i++)
                {
                    Console.WriteLine($"{i + 1,2} ");
                }

                MenuColor.SetColor(MenuColor.Color.Classic);
            }

            #endregion

            #region RandMasesLine

            /// <summary>
            /// Функция по заполнению массива рандомом
            /// </summary>
            /// <param name="mas">Возвращает заполненный массив</param>
            static public void RandMas(ref int[] mas, int min = -10, int max = 10)
            {
                Random rand = new Random();

                int len = mas.Length;

                for (int i = 0; i < len; i++)
                {
                    mas[i] = rand.Next(min, max);
                }
            }

            /// <summary>
            /// Функция по заполнению массива символов рандомом
            /// </summary>
            /// <param name="mas">Возвращает заполненный массив символов</param>
            static public void RandMas(ref char[] mas)
            {
                Random rand = new Random();

                int len = mas.Length;

                for (int i = 0; i < len; i++)
                {
                    mas[i] = (char)rand.Next(0x21, 0xFF);
                }
            }

            #endregion

            #region RandMasesTab

            /// <summary>
            /// Функция по заполнению двумерного массива рандомом
            /// </summary>
            /// <param name="mas">Возвращает заполненный массив</param>
            static public void RandMas(ref int[,] mas, int min = -10, int max = 10)
            {
                Random rand = new Random();

                int
                    lenx = mas.GetLength(0),
                    leny = mas.GetLength(1);

                for (int i = 0; i < lenx; i++)
                {
                    for (int j = 0; j < leny; j++)
                    {
                        mas[i, j] = rand.Next(min, max);
                    }
                }
            }

            /// <summary>
            /// Функция по заполнению двумерного массива символов рандомом
            /// </summary>
            /// <param name="mas">Возвращает заполненный массив символов</param>
            static public void RandMas(ref char[,] mas)
            {
                Random rand = new Random();

                int
                    lenx = mas.GetLength(0),
                    leny = mas.GetLength(1);

                for (int i = 0; i < lenx; i++)
                {
                    for (int j = 0; j < leny; j++)
                    {
                        mas[i, j] = (char)rand.Next(0x21, 0xFF);
                    }
                }
            }

            #endregion

            #region RandMasesStab

            /// <summary>
            /// Функция по заполнению 'рваного' массива рандомом
            /// </summary>
            /// <param name="mas">Возвращает заполненный массив</param>
            static public void RandMas(ref int[][] mas, int min = -10, int max = 10)
            {
                Random rand = new Random();

                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < mas[i].Length; j++)
                    {
                        mas[i][j] = rand.Next(min, max);
                    }
                }
            }

            /// <summary>
            /// Функция по заполнению 'рваного' массива символов рандомом
            /// </summary>
            /// <param name="mas">Возвращает заполненный массив символов</param>
            static public void RandMas(ref char[][] mas)
            {
                Random rand = new Random();

                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < mas[i].Length; j++)
                    {
                        mas[i][j] = (char)rand.Next(0x21, 0xFF);
                    }
                }
            }

            #endregion

            #region SettingsMasStab

            /// <summary>
            /// Функция по определению кол-ва строк в 'рваном' массиве
            /// </summary>
            /// <param name="maxx">Максимальное кол-во строк</param>
            /// <param name="maxy">Максимальное кол-во столбцов</param>
            /// <returns></returns>
            static public int[] DownMas(int maxx = 10, int maxy = 10)
            {
                int kol = 1;

                ConsoleKey key;

                bool end = false;

                for (int i = 0; i < maxx; i++) Console.WriteLine();

                while (!end)
                {
                    Console.CursorTop = Console.CursorTop - maxx;

                    Console.CursorLeft = 0;

                    for (int i = 1; i <= maxx; i++)
                    {
                        MenuColor.SetColor(MenuColor.Color.Sky);

                        if (i <= kol) MenuColor.ReverseColor();

                        Console.WriteLine($"{i,2} ");

                        MenuColor.SetColor(MenuColor.Color.Classic);
                    }

                    key = Console.ReadKey(false).Key;

                    switch (key)
                    {
                        case ConsoleKey.DownArrow:
                            if (kol < maxx) kol++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (kol > 1) kol--;
                            break;
                        case ConsoleKey.Enter:
                            end = true;
                            break;
                    }
                }

                Console.ResetColor();

                Console.CursorTop = Console.CursorTop - maxx;

                for (int i = 0; i < maxx; i++) Console.WriteLine("   ");

                Console.CursorTop = Console.CursorTop - maxx;

                return ParamsMas(kol, true, maxx, maxy);
            }

            /// <summary>
            /// Функция по определению массива параметров
            /// </summary>
            /// <param name="kol">Кол-во массивов в 'рваном' массиве</param>
            /// <param name="isnew">Надо ли стирать предыдущее</param>
            /// <param name="maxx">Максимальное кол-во элементов в массиве</param>
            /// <param name="maxy">Максимальное кол-во массивов</param>
            /// <returns>Возвращает массив параметров</returns>
            static public int[] ParamsMas(int kol, bool isnew = true, int maxx = 10, int maxy = 10)
            {
                ConsoleKey key;

                int[] Par = new int[kol];

                for (int i = 0; i < kol; i++) Par[i] = 1;

                bool end = false;

                int posy = 1;

                if (isnew)
                    for (int i = 0; i <= kol; i++) Console.WriteLine();

                int posend = Console.CursorTop;

                while (!end)
                {
                    Console.CursorTop = Console.CursorTop - kol - 1;

                    Console.CursorLeft = 0;

                    MenuColor.SetColor(MenuColor.Color.Sky);

                    Console.Write(@" \ ");

                    for (int i = 1; i <= maxx; i++) Console.Write($"{i,2} ");

                    Console.ResetColor();

                    Console.WriteLine();

                    for (int i = 0; i < kol; i++)
                    {
                        MenuColor.SetColor(MenuColor.Color.Sky);

                        Console.Write($"{i + 1,2} ");

                        Console.ResetColor();

                        if (i + 1 == posy)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else Console.ResetColor();

                        for (int j = 1; j <= maxy; j++)
                        {
                            if (j > Par[i]) Console.ResetColor();

                            if (j < Par[i]) Console.Write(" - ");
                            else if (j == Par[i]) Console.Write(" @ ");
                            else Console.Write("   ");
                        }

                        Console.ResetColor();

                        Console.Write(" | ");

                        MenuColor.SetColor(MenuColor.Color.Sky);

                        Console.Write(Par[i]);

                        MenuColor.SetColor(MenuColor.Color.Classic);

                        Console.Write(" ");

                        if (posy == i + 1) Console.WriteLine("<");
                        else Console.WriteLine(" ");
                    }

                    key = Console.ReadKey(false).Key;

                    switch (key)
                    {
                        case ConsoleKey.DownArrow:
                            if (posy < kol) posy++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (posy > 1) posy--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (Par[posy - 1] < 10) Par[posy - 1]++;
                            break;
                        case ConsoleKey.LeftArrow:
                            if (Par[posy - 1] > 1) Par[posy - 1]--;
                            break;
                        case ConsoleKey.Enter:
                            end = true;
                            break;
                    }
                }

                Console.ResetColor();

                Console.CursorTop = posend + 2;

                Console.CursorLeft = 0;

                return Par;
            }

            #endregion

            /// <summary>
            /// Функция по настройке размеров двумерного массива
            /// </summary>
            /// <param name="lenx">Кол-во столбцов</param>
            /// <param name="leny">Кол-во строк</param>
            /// <param name="maxx">Максимальное кол-во столбцов</param>
            /// <param name="maxy">Максимальное кол-во строк</param>
            static public void ParamsTableMas(out int posy, out int posx, int maxx = 10, int maxy = 10)
            {
                posx = 1; posy = 1;

                bool end = false;

                while (!end)
                {
                    Console.Clear();

                    ConsoleKey key;

                    Console.Write("Матрица: ");

                    MenuColor.SetColor(MenuColor.Color.Sky);

                    Console.Write($"{posx} X {posy}");

                    Console.WriteLine();

                    Console.Write(@" \ ");

                    for (int i = 1; i <= maxx; i++)
                    {
                        if (i == posx)
                        {
                            MenuColor.ReverseColor();
                        }
                        else MenuColor.SetColor(MenuColor.Color.Sky);
                        Console.Write($"{i,2} ");
                    }

                    MenuColor.SetColor(MenuColor.Color.Classic);

                    Console.WriteLine();

                    for (int i = 1; i <= maxy; i++)
                    {
                        if (i == posy)
                        {
                            MenuColor.ReverseColor();
                        }
                        else MenuColor.SetColor(MenuColor.Color.Sky);

                        Console.Write($"{i,2} ");

                        MenuColor.SetColor(MenuColor.Color.Classic);

                        for (int j = 1; j <= maxx; j++)
                        {
                            if (i <= posy && j <= posx)
                            {
                                Console.BackgroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                /*if ((i == posy && j <= posx) || (j == posx && i <= posy))
                                {
                                    Console.BackgroundColor = ConsoleColor.Cyan;
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                }*/
                                //else 
                                Console.ResetColor();
                            }

                            if (i == posy)
                            {
                                if (j < posx) Console.Write(" - ");
                                if (j == posx) Console.Write(" @ ");
                                if (j > posx) Console.Write("   ");
                            }
                            else
                            {
                                if (i < posy && j == posx) Console.Write(" | ");
                                else Console.Write("   ");
                            }
                        }

                        Console.WriteLine();
                    }

                    Console.ResetColor();

                    key = Console.ReadKey(false).Key;

                    switch (key)
                    {
                        case ConsoleKey.DownArrow:
                            if (posy < maxy) posy++;
                            break;
                        case ConsoleKey.UpArrow:
                            if (posy > 1) posy--;
                            break;
                        case ConsoleKey.RightArrow:
                            if (posx < maxx) posx++;
                            break;
                        case ConsoleKey.LeftArrow:
                            if (posx > 1) posx--;
                            break;
                        case ConsoleKey.Enter:
                            end = true;
                            break;
                    }
                }
            }

            #region Instructions

            /// <summary>
            /// Инструкция по заполнению двумерного массива
            /// </summary>
            static public void InstToTable()
            {
                int delay = 1000;//1000

                Console.CursorVisible = false;

                Console.Clear();

                Console.WriteLine("Для создания массива надо настроить его размеры \n");

                Thread.Sleep(delay);

                Console.WriteLine("Размеры матрицы");

                Thread.Sleep(delay);

                Console.Write("В самой верхней строке: ");

                Thread.Sleep(delay);

                MenuColor.SetColor(MenuColor.Color.Sky);

                Console.WriteLine("x X y\n");

                MenuColor.SetColor(MenuColor.Color.Classic);

                Thread.Sleep(delay);

                Console.Write("Параметры:");

                Console.WriteLine();

                Thread.Sleep(delay);

                Console.Write("Количество столбцов-----/");

                Console.CursorTop = Console.CursorTop - 2;

                Console.CursorLeft = Console.CursorLeft - 1;

                Console.Write("^");

                Console.CursorLeft = Console.CursorLeft - 1;

                Console.CursorTop = Console.CursorTop + 1;

                Console.Write("|");

                Console.CursorTop = Console.CursorTop + 2;

                Console.CursorLeft = 0;

                Thread.Sleep(delay);

                Console.Write("Количество строк------------/");

                Console.CursorLeft = Console.CursorLeft - 1;

                Console.CursorTop = Console.CursorTop - 3;

                Console.Write("^");

                for (int i = 1; i <= 2; i++)
                {
                    Console.CursorLeft = Console.CursorLeft - 1;

                    Console.CursorTop = Console.CursorTop + 1;

                    Console.Write("|");
                }

                Console.CursorTop = Console.CursorTop + 2;

                Console.CursorLeft = 0;

                Thread.Sleep(delay);

                Console.WriteLine();

                Console.WriteLine("Для продолжения нажмите кнопку");

                Console.ReadKey();

                Console.WriteLine();

                Console.WriteLine("Для настройки размеров массива используйте стрелки\n");

                Thread.Sleep(delay);

                Console.Write("Нажмите стрелку ");

                Console.Write("ВЛЕВО");

                Console.WriteLine();

                Console.Write("Для увеличения кол-ва столбцов");

                Console.CursorTop = Console.CursorTop - 1;

                ConsoleColor color;

                Thread.Sleep(delay);

                for (int i = 1; i <= 4; i++)
                {
                    Console.CursorLeft = 21 - 5;

                    color = Console.ForegroundColor;

                    Console.ForegroundColor = Console.BackgroundColor;

                    Console.BackgroundColor = color;

                    Console.Write("ВЛЕВО");

                    Thread.Sleep(delay);

                    Console.ResetColor();

                    Console.CursorLeft = 21 - 5;

                    Console.Write("ВЛЕВО");

                    Console.Write(" ");

                    Console.BackgroundColor = ConsoleColor.DarkCyan;

                    for (int j = 1; j <= i; j++) Console.Write(" ");

                    Console.ResetColor();

                    Thread.Sleep(delay);
                }

                Console.CursorLeft = 0; Console.CursorTop = Console.CursorTop + 3;

                Console.Write("Нажмите стрелку ");

                Console.Write("ВПРАВО");

                Console.WriteLine();

                Console.Write("Для уменьшения кол-ва столбцов");

                Console.CursorTop = Console.CursorTop - 1;

                for (int i = 4; i > 0; i--)
                {
                    Console.CursorLeft = 21 - 5;

                    color = Console.ForegroundColor;

                    Console.ForegroundColor = Console.BackgroundColor;

                    Console.BackgroundColor = color;

                    Console.Write("ВПРАВО");

                    Thread.Sleep(delay);

                    Console.ResetColor();

                    Console.CursorLeft = 21 - 5;

                    Console.Write("ВПРАВО");

                    Console.Write("     ");

                    Console.CursorLeft = Console.CursorLeft - 4;

                    Console.BackgroundColor = ConsoleColor.DarkCyan;

                    for (int j = 1; j <= i; j++) Console.Write(" ");

                    Console.ResetColor();

                    Thread.Sleep(delay);
                }

                Console.CursorLeft = 0; Console.CursorTop = Console.CursorTop + 3;

                Console.Write("Нажмите стрелку ");

                Console.Write("ВНИЗ");

                Console.WriteLine();

                Console.Write("Для увеличения\nкол-ва строк");

                Console.CursorTop = Console.CursorTop - 2;

                for (int i = 1; i <= 3; i++)
                {
                    Console.CursorLeft = 21 - 5;

                    color = Console.ForegroundColor;

                    Console.ForegroundColor = Console.BackgroundColor;

                    Console.BackgroundColor = color;

                    Console.Write("ВНИЗ");

                    Thread.Sleep(delay);

                    Console.ResetColor();

                    Console.CursorLeft = 21 - 5;

                    Console.Write("ВНИЗ");

                    Console.Write("  ");

                    Console.BackgroundColor = ConsoleColor.DarkCyan;

                    int x = Console.CursorTop;

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("    ");

                        Console.CursorLeft = Console.CursorLeft - 4;

                        Console.CursorTop = Console.CursorTop + 1;
                    }

                    Console.CursorTop = x;

                    Console.ResetColor();

                    Thread.Sleep(delay);
                }

                Console.CursorLeft = 0; Console.CursorTop = Console.CursorTop + 4;

                Console.Write("Нажмите стрелку ");

                Console.Write("ВВЕРХ");

                Console.WriteLine();

                Console.Write("Для уменьшения\nкол-ва строк");

                Console.CursorTop = Console.CursorTop - 2;

                for (int i = 3; i > 0; i--)
                {
                    Console.CursorLeft = 21 - 5;

                    color = Console.ForegroundColor;

                    Console.ForegroundColor = Console.BackgroundColor;

                    Console.BackgroundColor = color;

                    Console.Write("ВВЕРХ");

                    Thread.Sleep(delay);

                    Console.ResetColor();

                    Console.CursorLeft = 21 - 5;

                    Console.Write("ВВЕРХ");

                    Console.Write(" ");

                    int x = Console.CursorTop;

                    for (int j = 1; j <= 4; j++)
                    {
                        Console.Write("    ");

                        Console.CursorLeft = Console.CursorLeft - 4;

                        Console.CursorTop = Console.CursorTop + 1;
                    }

                    Console.CursorTop = x;

                    Console.BackgroundColor = ConsoleColor.DarkCyan;

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("    ");

                        Console.CursorLeft = Console.CursorLeft - 4;

                        Console.CursorTop = Console.CursorTop + 1;
                    }

                    Console.CursorTop = x;

                    Console.ResetColor();

                    Thread.Sleep(delay);
                }

                Console.CursorLeft = 0; Console.CursorTop = Console.CursorTop + 4;

                Console.WriteLine("");

                Console.CursorVisible = true;

                Console.WriteLine("Для возвращения в меню нажмите кнопку");

                Console.ReadKey();
            }

            /// <summary>
            /// Инструкция по заполнению 'рваного' массива
            /// </summary>
            static public void InstToStab()
            {
                int delay = 1000;//1000

                Console.CursorVisible = false;

                Console.Clear();

                Console.WriteLine("Для настройки размеров рваного массива\n   необходимо указать кол-во строк\n");

                Thread.Sleep(delay);

                MenuColor.SetColor(MenuColor.Color.Sky);

                MenuColor.ReverseColor();

                Console.WriteLine($"{1,2} ");

                MenuColor.ReverseColor();

                for (int i = 2; i <= 5; i++) Console.WriteLine($"{i,2} ");

                MenuColor.SetColor(MenuColor.Color.Classic);

                Thread.Sleep(delay);

                Console.CursorTop = Console.CursorTop - 4;

                Console.CursorLeft = 4;

                Console.Write("<----- Это столбец со строками");

                Thread.Sleep(delay * 2);

                //---------------------

                Console.CursorLeft = 4;

                Console.Write("                              ");

                Console.CursorTop = Console.CursorTop - 1;

                Console.CursorLeft = 4;

                Console.Write("<----- Это ");

                MenuColor.SetColor(MenuColor.Color.Sky);

                Console.Write("курсор");

                MenuColor.SetColor(MenuColor.Color.Classic);

                Thread.Sleep(delay);

                Console.CursorTop++;

                Console.CursorLeft = 4;

                Console.Write("Он показывет кол-во строк");

                Thread.Sleep(delay);

                Console.CursorTop++;

                Console.CursorLeft = 7;

                Console.Write("в будующем массиве");

                Thread.Sleep(delay * 2);

                Console.CursorTop = Console.CursorTop - 2;

                Console.CursorLeft = 4;

                Console.Write("                 ");

                Console.CursorTop++;

                Console.CursorLeft = 4;

                Console.Write("                         ");

                Console.CursorTop++;

                Console.CursorLeft = 7;

                Console.Write("                  ");

                //Thread.Sleep(delay * 2);

                //--------------

                Console.CursorTop = Console.CursorTop - 2;

                Console.CursorLeft = 7;

                Console.Write("Для увеличения кол-ва строк");

                Thread.Sleep(delay);

                Console.CursorTop++;

                Console.CursorLeft = 10;

                Console.Write("Нажмите ");

                Thread.Sleep(delay);

                Console.Write("ВНИЗ");

                for (int i = 2; i <= 5; i++)
                {
                    Console.CursorTop = 4;

                    Console.CursorLeft = 18;

                    MenuColor.ReverseColor();

                    Console.Write("ВНИЗ");

                    Thread.Sleep(delay);

                    Console.CursorLeft = 18;

                    MenuColor.ReverseColor();

                    Console.Write("ВНИЗ");

                    Console.CursorLeft = 0;

                    Console.CursorTop = i + 2;

                    MenuColor.SetColor(MenuColor.Color.Sky);

                    MenuColor.ReverseColor();

                    Console.Write($"{i,2} ");

                    MenuColor.SetColor(MenuColor.Color.Classic);

                    Thread.Sleep(delay);
                }

                //------------------

                Thread.Sleep(delay);

                Console.CursorTop = 6;

                Console.CursorLeft = 7;

                Console.Write("Для уменьшения кол-ва строк");

                Thread.Sleep(delay);

                Console.CursorTop++;

                Console.CursorLeft = 10;

                Console.Write("Нажмите ");

                Thread.Sleep(delay);

                Console.Write("ВВЕРХ");

                for (int i = 5; i > 3; i--)
                {
                    Console.CursorTop = 7;

                    Console.CursorLeft = 18;

                    MenuColor.ReverseColor();

                    Console.Write("ВВЕРХ");

                    Thread.Sleep(delay);

                    Console.CursorLeft = 18;

                    MenuColor.ReverseColor();

                    Console.Write("ВВЕРХ");

                    Console.CursorLeft = 0;

                    Console.CursorTop = i + 2;

                    MenuColor.SetColor(MenuColor.Color.Sky);

                    Console.Write($"{i,2} ");

                    MenuColor.SetColor(MenuColor.Color.Classic);

                    Thread.Sleep(delay);
                }

                //----------------------

                Thread.Sleep(delay);

                Console.CursorTop = 9;

                Console.CursorLeft = 7;

                Console.Write("После настройки кол-ва строк");

                Thread.Sleep(delay);

                Console.CursorTop++;

                Console.CursorLeft = 10;

                Console.Write("Нажмите ВВОД");

                Thread.Sleep(delay * 2);

                MenuColor.ReverseColor();

                Console.CursorLeft = 18;

                Console.Write("ВВОД");

                Thread.Sleep(delay);

                MenuColor.ReverseColor();

                Console.Clear();

                //----------------------

                Console.WriteLine("    После нажатия появится\nнастройка каждой строки отдельно\n");

                Thread.Sleep(delay * 2);

                MenuColor.SetColor(MenuColor.Color.Sky);

                Console.Write(@" \ ");

                for (int i = 1; i <= 10; i++) Console.Write($"{i,2} ");

                Console.WriteLine();

                MenuColor.SetColor(MenuColor.Color.Classic);

                for (int i = 1; i <= 3; i++)
                {
                    MenuColor.SetColor(MenuColor.Color.Sky);

                    Console.Write($"{i,2} ");

                    MenuColor.SetColor(MenuColor.Color.Classic);

                    if (i == 1)
                        MenuColor.ReverseColor();

                    Console.WriteLine(" @ ");
                }

                //----------------------

                MenuColor.SetColor(MenuColor.Color.Classic);

                Console.CursorTop = Console.CursorTop - 3;

                Console.CursorLeft = 7;

                Console.Write("<----- Это ");

                Thread.Sleep(delay);

                MenuColor.ReverseColor();

                Console.Write("курсор");

                MenuColor.ReverseColor();

                Console.CursorTop++;

                Console.CursorLeft = 10;

                Thread.Sleep(delay * 2);

                Console.Write("Он показывает строку,");

                Console.CursorTop++;

                Console.CursorLeft = 10;

                Thread.Sleep(delay);

                Console.Write("которая настраивается");

                Thread.Sleep(delay * 2);

                //----------------------

                Console.CursorTop = Console.CursorTop - 2;

                Console.CursorLeft = 7;

                Console.Write("                 ");

                Console.CursorTop++;

                Console.CursorLeft = 10;

                Console.Write("                     ");

                Console.CursorTop++;

                Console.CursorLeft = 10;

                Console.Write("                     ");

                Console.CursorTop = Console.CursorTop - 3;

                for (int i = 1; i <= 3; i++)
                {
                    Console.CursorTop++;

                    Console.CursorLeft = 3 * 11 - 1;

                    Console.Write(" | ");

                    MenuColor.SetColor(MenuColor.Color.Sky);

                    Console.Write("1");

                    MenuColor.SetColor(MenuColor.Color.Classic);
                }

                //--------------------

                Thread.Sleep(delay);

                Console.CursorTop++;

                Console.CursorLeft--;

                Console.Write("^");

                Console.CursorTop++;

                Console.CursorLeft--;

                Console.Write("|");

                Console.CursorTop++;

                Console.CursorLeft = Console.CursorLeft - 7;

                Console.Write("Это кол-во элементов");

                Console.CursorTop++;

                Console.CursorLeft = Console.CursorLeft - 16;

                Console.Write("в каждой строке");

                Thread.Sleep(delay * 2);

                //----------------------

                Console.CursorLeft = 36;

                Console.CursorTop -= 3;

                Console.CursorLeft--;

                Console.Write(" ");

                Console.CursorTop++;

                Console.CursorLeft--;

                Console.Write(" ");

                Console.CursorTop++;

                Console.CursorLeft = Console.CursorLeft - 7;

                Console.Write("                    ");

                Console.CursorTop++;

                Console.CursorLeft = Console.CursorLeft - 16;

                Console.Write("               ");

                //----------------------

                Console.CursorTop = 7;

                Console.CursorLeft = 6;

                Console.Write("Для изменеия кол-ва элементов");

                Thread.Sleep(delay);

                Console.CursorTop++;

                Console.CursorLeft = 7;

                Console.Write("в строке используйте ВЛЕВО");

                Thread.Sleep(delay);

                for (int i = 1; i < 5; i++)
                {
                    Console.CursorTop = 8;

                    Console.CursorLeft = 28;

                    MenuColor.ReverseColor();

                    Console.Write("ВЛЕВО");

                    Thread.Sleep(delay);

                    Console.CursorLeft = 28;

                    MenuColor.ReverseColor();

                    Console.Write("ВЛЕВО");

                    Console.CursorTop = 4;

                    Console.CursorLeft = 3;

                    MenuColor.ReverseColor();

                    for (int j = 0; j < i; j++) Console.Write(" - ");

                    Console.Write(" @ ");

                    MenuColor.ReverseColor();

                    Thread.Sleep(delay);
                }

                //-----------------

                Console.CursorTop = 9;

                Console.CursorLeft = 25;

                Console.Write("и ВПРАВО");

                Thread.Sleep(delay);

                for (int i = 1; i < 3; i++)
                {
                    Console.CursorTop = 9;

                    Console.CursorLeft = 27;

                    MenuColor.ReverseColor();

                    Console.Write("ВПРАВО");

                    MenuColor.ReverseColor();

                    Thread.Sleep(delay);

                    Console.CursorTop = 9;

                    Console.CursorLeft = 27;

                    Console.Write("ВПРАВО");

                    Console.CursorTop = 4;

                    Console.CursorLeft = 15 - i * 3;

                    MenuColor.ReverseColor();

                    Console.Write(" @ ");

                    MenuColor.ReverseColor();

                    Console.Write("   ");

                    Thread.Sleep(delay);
                }

                //----------------------

                Thread.Sleep(delay);

                Console.CursorTop = 11;

                Console.CursorLeft = 6;

                Console.Write("Для перемещения между строками");

                Thread.Sleep(delay);

                Console.CursorTop = 12;

                Console.CursorLeft = 10;

                Console.Write("используйте стрелки");

                Thread.Sleep(delay);

                Console.CursorTop = 13;

                Console.CursorLeft = 13;

                Console.Write("ВНИЗ");

                Thread.Sleep(delay);

                Console.Write(" и ВВЕРХ");

                //----------------------

                Thread.Sleep(delay);

                Console.CursorTop = 15;

                Console.CursorLeft = 6;

                Console.Write("После завершения настройки");

                Thread.Sleep(delay);

                Console.CursorTop = 16;

                Console.CursorLeft = 10;

                Console.Write("нажмите ВВОД");

                Thread.Sleep(delay * 2);

                Console.CursorLeft = 18;

                MenuColor.ReverseColor();

                Console.Write("ВВОД");

                MenuColor.ReverseColor();

                Thread.Sleep(delay / 2);

                Console.CursorVisible = true;
            }

            #endregion
        }
    }
}