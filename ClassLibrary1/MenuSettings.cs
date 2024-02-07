using System;
using Menu.MenuApplication;

namespace Menu
{
    namespace MenuSettingMenu
    {
        public class SettingMenu
        {
            /*
            * Параметры NumOfPages и NumOfPoints(значения в массиве)
            * начинают отчёт с 1
            */
            public int numOfPages; //Кол-во страниц в меню
            public int[] numOfPoints; //Кол-во пунктов на каждой странице

            public string[][] names; //Надписи в меню для приложений

            public Application[][] Apps; //Ссылки на приложения

            public int NumOfPages
            {
                get => numOfPages;
                set => numOfPages = value;
            }

            public int[] NumOfPoints
            {
                get => numOfPoints;
                set => numOfPoints = value;
            }

            public string[][] Names
            {
                get => names;
                set => names = value;
            }

            /// <summary>
            /// Техническая функция по удобному заполнению настроек меню
            /// </summary>
            /// <param name="set">Класс настроек</param>
            /// <param name="Apps">Массив приложений</param>
            public void FormSettings(Application[][] AppsOut)
            {
                int Len = AppsOut.GetLength(0), i = 0, j = 0;
                int[] AppKol = new int[Len];
                Names = new string[Len][];

                foreach (Application[] ele in AppsOut)
                {
                    AppKol[i] = ele.Length;
                    Names[i] = new string[ele.Length];
                    j = 0;

                    foreach (Application app in ele)
                    {
                        Names[i][j] = app.Message;

                        j++;
                    }

                    i++;
                }

                NumOfPages = Len;
                NumOfPoints = AppKol;
                Apps = AppsOut;
            }

            /// <summary>
            /// Приложение "Настройка"
            /// </summary>
            public void SetupStyle()
            {
                Console.WriteLine("<Настройки>");

            }
        }
    }
}
