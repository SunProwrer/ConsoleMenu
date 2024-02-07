using System;

namespace MenuApplication
{
    public class Application
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
        public delegate Type App<Type, Input>(params Input[] Mas); // Mas - это параметры для приложения
    }
}
