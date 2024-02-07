using System;
using System.Threading;
using Menu.MenuApplication;
using Menu.MenuSettingMenu;
using Menu.MenuColors;

namespace Menu
{
    public class MenuCore
    {
        public int pos = 1;
        public int list = 1;
        private readonly string strelka = @"›";   //▸→

        public MenuCore()
        {
        }

        /// <summary>
        /// Функция по печати меню
        /// </summary>
        /// <param name="Set">Настройки меню</param>
        /// <param name="IsClear">Надо стерать предыдущее?</param>
        public void PrintMenu(SettingMenu Set, bool IsClear)
        {
            if (IsClear)
                Console.Clear();

            int i = 1;

            foreach (string mes in Set.Names[list - 1])
            {
                if (i == pos) Console.Write(strelka);

                Console.Write(" " + i + ")" + mes);

                Console.WriteLine();

                i++;
            }

            Console.WriteLine();

            Console.WriteLine($"<--Страница {list} из {Set.NumOfPages}-->");

            int len = 21, start = len / 2 - Set.NumOfPages / 2; i = 1;

            Console.CursorLeft = start;

            for (int j = 1; j <= Set.NumOfPages; j++)
            {
                if (j == list)
                    Console.BackgroundColor = ConsoleColor.Red;
                else
                    Console.BackgroundColor = ConsoleColor.Green;

                Console.Write(" ");
            }

            Console.ResetColor();

            Console.WriteLine();
        }

        /// <summary>
        /// Функция по определению позиции курсора
        /// </summary>
        /// <param name="Set">Настройки меню</param>
        /// <returns>Запуск приложения</returns>
        public bool GetPos(SettingMenu Set)
        {
            ConsoleKey key;

            while (true)
            {
                key = Console.ReadKey(false).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (pos == 1) pos = Set.NumOfPoints[list - 1];
                        else pos--;
                        return false;
                    case ConsoleKey.DownArrow:
                        if (pos == Set.NumOfPoints[list - 1]) pos = 1;
                        else pos++;
                        return false;
                    case ConsoleKey.LeftArrow:
                        if (list == 1) list = Set.NumOfPages;
                        else list--;
                        return false;
                    case ConsoleKey.RightArrow:
                        if (list == Set.NumOfPages) list = 1;
                        else list++;
                        return false;
                    case ConsoleKey.Enter:
                        return true;
                    case ConsoleKey.Escape:
                        pos = Set.NumOfPoints[list - 1];
                        return true;
                }
            }
        }

        /// <summary>
        /// Функция по объяснению управления меню
        /// </summary>
        public void Info()
        {
            Console.SetCursorPosition(24, 10);
            Console.Write("   Для перемещения по меню");

            Thread.Sleep(750);

            Console.SetCursorPosition(24, 11);
            Console.Write("     испольуйте ");

            Thread.Sleep(750);

            MenuColor.SetColor(MenuColor.Color.Sky);
            Console.Write("стрелки");
            MenuColor.SetColor(MenuColor.Color.Classic);

            Thread.Sleep(1500);

            Console.SetCursorPosition(24, 12);
            Console.Write("Для продолжения нажмите кнопку");

            Console.ReadKey();
        }
    }
}
