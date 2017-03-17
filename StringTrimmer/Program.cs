using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTrimmer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool YesOrNot;

            string fullInfo;
            string className;
            string methodNmae;

            int lineNumber = -1;

            //fullInfo = "Что-то слева от скобки (a( что то справа от скобки";
            fullInfo = "Что-то слева (()(от скобки (( что то справа от скобки";


            if (string.IsNullOrEmpty(fullInfo))
            {
                // Если входная строка пустая или равна null - то нечего синтаксически разбирать. 
                YesOrNot = false;
            }
            else
            {
                YesOrNot = true;
            }

            var parts1 = fullInfo.Split(new[] { "(" }, StringSplitOptions.RemoveEmptyEntries);

            // Если строка не разделена на две части, возвратить false.
            if (parts1.Length != 2)
            {
                YesOrNot = false;
            }

            foreach (var s in parts1)
            {
                Console.WriteLine("|" + s + "|");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            if (YesOrNot)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Значение YesOrNot = {YesOrNot}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Значение YesOrNot = {YesOrNot}");
            }

            Console.ForegroundColor = ConsoleColor.Gray;

            // Далее, пример с MSDN:
            // https://msdn.microsoft.com/en-us/library/d4tt83f9(v=vs.110).aspx
            Console.WriteLine();
            char[] charsToTrim = { '*', ' ', '\'' };
            string banner = "***\' Much Ado About Nothing \' ***";
            string result = banner.Trim(charsToTrim);
            Console.WriteLine("Trimmmed\n   {0}\nto\n   |{1}|", banner, result);

        }
    }
}
