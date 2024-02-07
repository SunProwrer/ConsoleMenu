using System;

namespace Menu
{
    namespace MenuGet
    {
        static public class Get
        {
            #region Integers

            /// <summary>
            /// Функция по вводу числа
            /// </summary>
            /// <param name="message">Сообщение о вводе числа</param>
            /// <returns>Возвращает введённое число</returns>
            static public int Int(string message = "")
            {
                int outint = 0;

                do
                {
                    if (!(message == "" || message == null))
                        Console.Write(message + ": ");
                }
                while
                (!int.TryParse(Console.ReadLine(), out outint));  //Это число?

                return outint;
            }

            /// <summary>
            /// Функция по вводу числа
            /// </summary>
            /// <param name="message">Сообщение о вводе числа</param>
            /// <param name="min">Минимальное значение введённого числа</param>
            /// <param name="max">Максимальное значение введённого числа</param>
            /// <returns>Возвращает введённое число</returns>
            static public int Int(string message = "", int min = -10, int max = 10)
            {
                int outint = 0;

                do
                {
                    if (!(message == "" || message == null))
                        Console.Write(message + ": ");
                }
                while 
                (!int.TryParse(Console.ReadLine(), out outint)  //Это число?
                || outint >= max || outint <= min);             //Оно входит в диапазон?

                return outint;
            }

            /// <summary>
            /// Функция по вводу числа
            /// </summary>
            /// <param name="message">Сообщение о вводе числа</param>
            /// <param name="numbers">Числа, которые надо на выходе</param>
            /// <returns>Возвращает введённое число</returns>
            static public int Int(string message = "", params int[] numbers)
            {
                int outint = 0;

                do
                {
                    if (!(message == "" || message == null))
                        Console.Write(message + ": ");
                }
                while 
                (!int.TryParse(Console.ReadLine(), out outint)  //Это число?
                || Array.IndexOf(numbers, outint) == -1);       //Оно входит в диапазон?

                return outint;
            }

            #endregion

            #region Char

            /// <summary>
            /// Функция по вводу символа
            /// </summary>
            /// <param name="message">Сообщение о вводе символа</param>
            /// <returns>Возвращает введённый символ</returns>
            static public char Char(string message = "")
            {
                char outchar = '-';

                do
                {
                    if (!(message == "" || message == null))
                        Console.Write(message + ": ");
                }
                while
                (!char.TryParse(Console.ReadLine(), out outchar));  //Это символ?

                return outchar;
            }

            /// <summary>
            /// Функция по вводу символа
            /// </summary>
            /// <param name="message">Сообщение о вводе символа</param>
            /// <param name="chars">Символы, которые надо на выходе</param>
            /// <returns>Возвращает введённый символ</returns>
            static public char Char(string message = "", params char[] chars)
            {
                char outchar = '-';

                do
                {
                    if (!(message == "" || message == null))
                        Console.Write(message + ": ");
                }
                while
                (!char.TryParse(Console.ReadLine(), out outchar)    //Это символ?
                || Array.IndexOf(chars, outchar) == -1);            //Он входит в диапазон?

                return outchar;
            }

            #endregion

            #region Double

            /// <summary>
            /// Функция по вводу вещественного числа
            /// </summary>
            /// <param name="message">Сообщение о вводе вещественного числа</param>
            /// <returns>Возвращает введённое вещественное число</returns>
            static public double Double(string message = "")
            {
                double outdouble = 0.0;

                do
                {
                    if (!(message == "" || message == null))
                        Console.Write(message + ": ");
                }
                while
                (!double.TryParse(Console.ReadLine(), out outdouble));  //Это вещественное число?

                return outdouble;
            }

            /// <summary>
            /// Функция по вводу вещественного числа
            /// </summary>
            /// <param name="message">Сообщение о вводе вещественного числа</param>
            /// <returns>Возвращает введённое вещественное число</returns>
            static public double Double(string message = "", double min = -99, double max = 100)
            {
                double outdouble = 0.0;

                do
                {
                    if (!(message == "" || message == null))
                        Console.Write(message + ": ");
                }
                while
                (!double.TryParse(Console.ReadLine(), out outdouble)  //Это вещественное число?
                || outdouble >= max || outdouble <= min);             //Оно входит в диапазон?

                return outdouble;
            }

            #endregion
        }
    }
}