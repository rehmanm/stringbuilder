using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Calculator
    {

        public static int Add(string numbers) {

            int result = 0;

            bool raiseNegativeNumberException = false;

            var GetSeperatorsTuple = GetSeperators(numbers);
            string[] separators = GetSeperatorsTuple.Item1;
            int startIndexOf = GetSeperatorsTuple.Item2;
            List<Int32> negativeNumberList = new List<int>();

            foreach (string str in numbers.Substring(startIndexOf).Split(separators, StringSplitOptions.None)) {
                
                int currentNumber = 0;

                Int32.TryParse(str, out currentNumber);

                if (currentNumber > 1000)
                    continue;

                if (currentNumber < 0)
                {
                    raiseNegativeNumberException = true;
                    negativeNumberList.Add(currentNumber);
                }

                result += currentNumber;

            }

            if (raiseNegativeNumberException) {

                throw new NegativeNumberNotAllowedException(negativeNumberList);

            }

            return result;

        }

        private static Tuple<string[], int> GetSeperators(string numbers) {

            string[] separators;
            int seperatorIndexOf = 0;

            if (numbers.StartsWith("//"))
            {
                
                seperatorIndexOf = numbers.IndexOf("\n");

                string extractSeperators = numbers.Substring(2, seperatorIndexOf-2);
                
                separators = extractSeperators.Split(','); 


            }
            else
            {

                separators = new string[1];
                separators[0] = ",";
            }

            return Tuple.Create(separators, seperatorIndexOf);
        }
    }
}
