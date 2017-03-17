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

            fullInfo = "Что-то слева от скобки (( что то справа от скобки";

            if (string.IsNullOrEmpty(fullInfo))
            {
                // Если входная строка пустая или равна null - то нечего синтаксически разбирать. 
                YesOrNot = false;
            }
            else
            {
                YesOrNot = true;
            }

            Console.WriteLine($"Значение YesOrNot = {YesOrNot}");


        }
    }
}
