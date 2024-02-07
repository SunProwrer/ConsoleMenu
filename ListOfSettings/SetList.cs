using System;
using Menu.MenuColors;

namespace Menu
{
    namespace ListOfSettings
    {
        public static class SetList
        {
            /// <summary>
            /// Функция по печати меню заполнения массива
            /// </summary>
            /// <param name="pos">Позиция курсора на экране</param>
            /// <param name="down">Номер строки с выбором режима заполнения</param>
            static public void PrintMenuIn(int pos)
            {
                try
                {
                    //Console.SetCursorPosition(0, Console.CursorLeft);

                    Console.CursorLeft = 0;

                    Console.CursorTop = Console.CursorTop - 2;

                    //Console.WriteLine("                                          ");

                    //Console.SetCursorPosition(0, Console.CursorLeft);

                    Console.CursorLeft = 0;

                    //Console.CursorTop = Console.CursorTop - 2;
                }
                catch (Exception)
                {

                }

                Console.WriteLine("Как вы хотите наполнить элементами массив?");

                string[] Menu =
                {
                "Генератор рандома",
                "Ручной ввод"
            };

                string strelka = @"› ", strelkarev = @" ‹";

                int i = 1;

                foreach (string mes in Menu)
                {
                    if (i == pos)
                    {
                        Console.Write(strelka + mes + strelkarev + " ");
                    }
                    else
                        Console.Write(mes + " ");

                    i++;
                }

                Console.WriteLine();
            }

            /// <summary>
            /// Функция по определению позиции курсора (меню заполнения)
            /// </summary>
            /// <param name="pos">Позиция курсора на экране</param>
            /// <returns>Возвращает нажатие на enter (запуск заполнения)</returns>
            static public bool GetPosIn(ref int pos)
            {
                ConsoleKey key;

                while (true)
                {
                    key = Console.ReadKey(false).Key;

                    switch (key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (pos < 2)
                                pos++;
                            else
                                pos--;
                            return false;
                        case ConsoleKey.RightArrow:
                            if (pos > 1)
                                pos--;
                            else
                                pos++;
                            return false;
                        case ConsoleKey.Enter:
                            return true;
                    }
                }
            }

            static public void PrintSet()
            {

            }
        }
    }
}