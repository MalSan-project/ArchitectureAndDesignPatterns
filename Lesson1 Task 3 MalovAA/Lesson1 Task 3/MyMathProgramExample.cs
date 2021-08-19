using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task_3
{
    class MyMathProgramExample
    {

        string userAnswer;
        string startText = "Доброго времени суток, пользователь. Данная программа проводит различные операции с числом, которое ты сам введёшь.";
        string text = "Введите желаемое целое число для операций (для выхода введите q) => ";
        string wrongAnswer = "Вы ввели недопустимый формат числа. Повторите пожалуйста ввод.";
        string userNumberMessage = "Ваше активное число =>";
        string exitText = "Благодарю за использование моей математической программы. До новых встречь на следующих домашних работах.";
        string exitAnswer = "q";




        public bool CheckUserAnswer(out int userNumber)
        {
            userNumber = 0;
            do
            {
                MyMathProgramIO.PrintText(text);
                userAnswer = Console.ReadLine();
                if (userAnswer.Equals(exitAnswer))
                {
                    MyMathProgramIO.PrintTextLn(exitText);
                    MyMathProgramIO.WaitForInput();
                    return false;
                }
                else
                    if (int.TryParse(userAnswer, out userNumber))
                {
                    MyMathProgramIO.PrintTextLn(userNumberMessage, userNumber);
                    return true;
                }
                else
                    MyMathProgramIO.PrintText(wrongAnswer);
            }
            while (true);
        }
        public void Run()
        {
            MyMathProgramIO.PrintTextLn(startText);

            while (CheckUserAnswer(out int userNumber))
            {
                MyMathOperations exampleOperations = new MyMathOperations();
                exampleOperations.GetResults(userNumber);
                MyMathProgramIO.PrintTextLn(exampleOperations.FactorialMessage, exampleOperations.Factorial);
                MyMathProgramIO.PrintTextLn(exampleOperations.SumMessage, exampleOperations.Sum);
                MyMathProgramIO.PrintTextLn(exampleOperations.MaxEvenMessage, exampleOperations.MaxEven);
            }

        }

    }
}
