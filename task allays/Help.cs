using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_allays
{
    internal class Help
    {
        public static int FindLength(string x)
        {
        l1:

            Console.WriteLine("massivlerin uzunluqunu daxil edin");

            if (!int.TryParse(Console.ReadLine(), out int len))
            {                
                goto l1;

            }     
            return len;
        }
    }
}
