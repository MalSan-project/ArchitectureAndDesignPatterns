using System;
using System.Numerics;

namespace Lesson1_Task_3
{
    public sealed class MyMathOperations
    {
        private BigInteger _factorial = 1;
        private String _factorialMessage = "Факториал данного числа =";
        private int _sum;
        private String _sumMessage = "Сумма чисел от 1 до данного числа =";
        private int _maxEven;
        private String _maxEvenMessage = "МАксимальное чётное число, меньше данного = ";

        public BigInteger Factorial => _factorial;
        public String FactorialMessage => _factorialMessage;
        public int Sum => _sum;
        public String SumMessage => _sumMessage;
        public int MaxEven => _maxEven;
        public String MaxEvenMessage => _maxEvenMessage;

        /// <summary>
        /// Метод, принимающий на вход пользовательское число, и проводящий с ним все необходимые математические операции.
        /// </summary>
        /// <param name="number"></param>
        public void GetResults(int number)
        {
            for (int tempNumber = 1; tempNumber <= number; tempNumber++)
            {
                _sum += tempNumber;
                _factorial *= tempNumber;
                if ((tempNumber - 1) % 2 == 0)
                    _maxEven = tempNumber - 1;
            }
        }

    }
}
