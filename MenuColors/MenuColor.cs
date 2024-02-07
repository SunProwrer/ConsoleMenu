using System;

namespace Menu
{
    namespace MenuColors
    {
        public static class MenuColor
        {
            /// <summary>
            /// Сочетания цветов
            /// </summary>
            public enum Color
            {
                Classic,
                Contrast_Green,
                Contrast_Cyan,
                Contrast_Red,
                Contrast_Magenta,
                Contrast_Yellow,
                Contrast_White,
                Deep,
                Forest,
                Sky,
                Sunset,
                Mess,
                Mix,
                Alcreme,
                Inverse
            }

            /// <summary>
            /// Функция, которая устанавливает цвет в выводе
            /// </summary>
            /// <param name="color">Сочетание цвета</param>
            static public void SetColor(Color color)
            {
                switch (color)
                {
                    case Color.Classic:
                        Console.ResetColor();
                        break;
                    case Color.Contrast_Green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Color.Contrast_Cyan:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case Color.Contrast_Red:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Color.Contrast_Magenta:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case Color.Contrast_Yellow:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Color.Contrast_White:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case Color.Deep:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case Color.Forest:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Color.Sky:
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case Color.Sunset:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Color.Mess:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case Color.Mix:
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case Color.Alcreme:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                }
            }

            /// <summary>
            /// Функция, которая возвращает цвет
            /// </summary>
            /// <param name="color">Сочетание цвета</param>
            static public (ConsoleColor, ConsoleColor) GetColor(Color color)
            {
                switch (color)
                {
                    case Color.Classic:
                        return (ConsoleColor.Black, ConsoleColor.Gray);
                    case Color.Contrast_Green:
                        return (ConsoleColor.Black, ConsoleColor.Green);
                    case Color.Contrast_Cyan:
                        return (ConsoleColor.Black, ConsoleColor.Cyan);
                    case Color.Contrast_Red:
                        return (ConsoleColor.Black, ConsoleColor.Red);
                    case Color.Contrast_Magenta:
                        return (ConsoleColor.Black, ConsoleColor.Magenta);
                    case Color.Contrast_Yellow:
                        return (ConsoleColor.Black, ConsoleColor.Yellow);
                    case Color.Contrast_White:
                        return (ConsoleColor.Black, ConsoleColor.White);

                    case Color.Deep:
                        return (ConsoleColor.DarkBlue, ConsoleColor.Yellow);
                    case Color.Forest:
                        return (ConsoleColor.DarkGreen, ConsoleColor.Green);
                    case Color.Sky:
                        return (ConsoleColor.DarkCyan, ConsoleColor.Cyan);
                    case Color.Sunset:
                        return (ConsoleColor.DarkRed, ConsoleColor.Red);
                    case Color.Mess:
                        return (ConsoleColor.DarkYellow, ConsoleColor.Gray);
                    case Color.Mix:
                        return (ConsoleColor.Gray, ConsoleColor.White);
                    case Color.Alcreme:
                        return (ConsoleColor.White, ConsoleColor.Magenta);
                    default:
                        return (ConsoleColor.Black, ConsoleColor.Gray);
                }
            }

            /// <summary>
            /// Функция по инвертированию цвета вывода
            /// </summary>
            static public void ReverseColor()
            {
                ConsoleColor color = Console.BackgroundColor;

                Console.BackgroundColor = Console.ForegroundColor;

                Console.ForegroundColor = color;
            }
        }
    }
}