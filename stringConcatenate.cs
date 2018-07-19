/*
 * FILE NAME: stringConcatenate.cs
 * PROJECT NAME: Arithmetic Project
 * DATE INITIATLIZED: 18 July 2018
 * DESCRIPTION: A C# program designed to concatenate two strings
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringConcatenate{
    class Program {
        static void Main(string[] args)
        {
            string firstSTR = "digga";
            string secondSTR = "dogga";

            string answer = firstSTR + secondSTR;

            Console.WriteLine("Your two string values: " + firstSTR + " " + secondSTR);
            Console.ReadKey();
        }
    }
}
