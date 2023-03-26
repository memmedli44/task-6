using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_allays
{
    internal class Helper
    {
        public static int[] FillArray(int len,string capsion)
        {
            int[] x=new int[len];

            Console.WriteLine("massivin elementlerini daxil edin:");

            for (int i = 0; i < x.Length; i++)
            {
            l2:
                Console.Write($"{capsion}[{i + 1}]= ");
                if (!int.TryParse(Console.ReadLine(), out int array))
                {
                    goto l2;
                }
               
            }
            return x;
        }

    }
}
