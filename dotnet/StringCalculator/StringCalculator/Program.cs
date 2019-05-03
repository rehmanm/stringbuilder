using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Model;
namespace StringCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("String Calculator");

            Console.WriteLine("Task 1");
            Console.WriteLine($"b. {Model.Calculator.Add("")}");
            Console.WriteLine($"c. {Model.Calculator.Add("1,2,6")}");
            Console.WriteLine($"d. {Model.Calculator.Add("1,2,5")}");
            Console.WriteLine("Task 2");
            Console.WriteLine($"a. {Calculator.Add("1\n,2,3")}");
            Console.WriteLine($"b. {Calculator.Add("1,\n2,4")}");

            Console.WriteLine("Task 3");
            Console.WriteLine($"c. {Model.Calculator.Add("//;\n1;3;4")}");
            Console.WriteLine($"e1. {Model.Calculator.Add("//$\n1$2$3")}");
            Console.WriteLine($"e2. {Model.Calculator.Add("//@\n2@3@8")}");

            Console.WriteLine("Bonus");
            Console.WriteLine($"1. {Model.Calculator.Add("2,1001")}");
            Console.WriteLine($"2. {Model.Calculator.Add("//***\n1***2***3")}");
            Console.WriteLine($"3. {Model.Calculator.Add("//$,@\n1$2@3")}");
            Console.WriteLine($"4. {Model.Calculator.Add("//***,$,@\n1$2@3***4")}");

            Console.WriteLine("Task 4");
            try
            {
                Model.Calculator.Add("-2,5, -3");
            }
            catch (NegativeNumberNotAllowedException e) {
                Console.WriteLine($"1. {e.Message}");
            }





            Console.Read();
        }
    }
}
