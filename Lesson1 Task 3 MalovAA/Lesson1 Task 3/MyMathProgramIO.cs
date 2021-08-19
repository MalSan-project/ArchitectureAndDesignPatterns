using System;
using System.Numerics;
using System.Text;

namespace Lesson1_Task_3
{
    public struct MyMathProgramIO
    {
        /// <summary>
        /// Вывод строки в окно консоли с переходом на новую строку в конце
        /// </summary>
        /// <param name="text"></param>
        public static void PrintTextLn(string text)
        {
            Console.WriteLine(text);
        }
        /// <summary>
        /// Вывод строки в окно консоли без перехода на новую строку в конце
        /// </summary>
        /// <param name="text"></param>
        public static void PrintText(string text)
        {
            Console.Write(text);
        }
        /// <summary>
        /// Вывод в окно консоли строки и результата путём конкотенации через StringMuilder. С переходом на новую строку в конце
        /// </summary>
        /// <param name="requirement"></param>
        /// <param name="result"></param>
        public static void PrintTextLn(string requirement, int result)
        {
            StringBuilder _textBuilder = new StringBuilder(requirement);
            _textBuilder.Append($" ");
            _textBuilder.Append(result);
            Console.WriteLine(_textBuilder);
        }
        /// <summary>
        /// Вывод в окно консоли строки и результата формата BigInteger путём конкотенации через StringMuilder. С переходом на новую строку в конце
        /// </summary>
        /// <param name="requirement"></param>
        /// <param name="result"></param>
        public static void PrintTextLn(string requirement, BigInteger result)
        {
            StringBuilder _textBuilder = new StringBuilder(requirement);
            _textBuilder.Append($" ");
            _textBuilder.Append(result);
            Console.WriteLine(_textBuilder);
        }
        /// <summary>
        /// Метод ожидания отклика пользователя
        /// </summary>
        public static void WaitForInput()
        {
            Console.ReadLine();
        }


    }
}
