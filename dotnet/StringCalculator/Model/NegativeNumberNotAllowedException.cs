using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class NegativeNumberNotAllowedException:Exception
    {
 
        public NegativeNumberNotAllowedException(List<Int32> numbers): base($"Negative Not Allowed : {String.Join(",", numbers.ToArray())}") {


            
        }
 

    }
}
