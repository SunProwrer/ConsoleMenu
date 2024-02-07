using System;
using static MenuApplication;

namespace MenuSettings
{
    public class Settings
    {
        /// <summary>
        /// На какой странице находится приложение
        /// </summary>
        public int Page;

        /// <summary>
        /// На какой позиции находится приложение
        /// </summary>
        public int Position;

        /// <summary>
        /// Название приложения (то, что напишется в меню)
        /// </summary>
        public string Message;

        /// <summary>
        /// Ссылка на приложение (функцию)
        /// </summary>
        public delegate Type App<Type, Input>(params Input[] Mas);

        /// <summary>
        /// Техническая функция по удобному заполнению настроек меню
        /// </summary>
        /// <param name="set">Класс настроек</param>
        /// <param name="Apps">Массив приложений</param>
        public void FormSettings(Application[][] Apps)
        {
            int Len = Apps.GetLength(0), i = 0, j = 0;
            int[] AppKol = new int[Len];
            string[][] Names = new string[Len][];

            foreach (Application[] ele in Apps)
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

            Set.NumOfPages = Len;
            Set.NumOfPoints = AppKol;
            Set.Apps = Apps;
            Set.Names = Names;
        }
    }
}