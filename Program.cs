using System;
using CodingCampusCSharpHomework;
using System.Globalization;

namespace HomeworkTemplate
{
    class Program
    {
        static string ReverseString(string text)
        {
            if (text == null)
            {
                return null;
            }

            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new String(array);
        }
        static string Decor(char sign, int padding, bool isReverse = false)
        {
            string result = new String(sign, padding / 2) + new String(' ', padding / 2);
            return isReverse ? ReverseString(result) : result;
        }


        static void Main(string[] args)
        {
            Func<Task2, string> TaskSolver = task =>
            {
                System.Globalization.CultureInfo.CurrentCulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");

                return $"{Decor(task.DecorativeSign, Task2.Padding)}" +
                $"{task.Balance:C2}" +
                $"{Decor(task.DecorativeSign, Task2.Padding, true)}";
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
