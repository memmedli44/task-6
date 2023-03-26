using System.Security.Cryptography.X509Certificates;

namespace task_allays
{
    internal class Program
    {
        static void Main(string[] args)
        {
         #region task 6
        //l1:
        //    Console.WriteLine("massivlerin uzunluqunu daxil edin");

        //    if (!int.TryParse(Console.ReadLine(), out int len))
        //    {

        //        goto l1;
        //    }
        //    int[] x = HELPER.FillArray(len);
        //    Console.WriteLine("=================");
        //    int[] y = HELPER.FillArray(len);

        //    for (int i = 0; i < len; i++)
        //    {
        //        if (y[i] == (int)Math.Pow(x[i], 2))
        //        {
        //            Console.WriteLine($"{x[i]} , {y[i]}");
        //        }
        //    }
        #endregion
        
         #region task 7
        //l1:
        //    Console.WriteLine("massivlerin uzunluqunu daxil edin");

        //    if (!int.TryParse(Console.ReadLine(), out int len))
        //    {

        //        goto l1;
        //    }

        //    int[] x = Helper.FillArray(len,"x");



        //    int max = x[0];
        //    int min = x[0];
        //    for (int i = 0; i < x.Length; i++)
        //    {

        //        if (max < x[i])
        //        {
        //            max = x[i];
        //        }
        //        else if (min > x[i])
        //        {
        //            min = x[i];

        //        }

        //    }
        //    int average = (min + max) / 2;
        //    decimal geoMean =(decimal) Math.Pow(min * max, (1.0 / 2));
        //    Console.WriteLine($"ededi orta:{average} ");
        //    if (geoMean >= 0)
        //    {
        //        Console.WriteLine($"; hendesi orta:{geoMean}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("elementlerden biri 0-dan kicikdir");
        //    }
        #endregion
        
         #region task 8

        //int[] x = Helper.FillArray(4, "x");
        //Console.WriteLine("=================");
        //int[] y = Helper.FillArray(4, "y");

        //double[] result = new double[0];
        //for (int i = 0; i < x.Length; i++)
        //{
        //    double sum = x[i] * y[i];
        //    if (sum >= 0)
        //    {
        //        Array.Resize(ref result, result.Length + 1);
        //        result[result.Length - 1] = sum;
        //    }


        //}
        //if (result.Length == 0)
        //{
        //    Console.WriteLine("hasillerin hamisi menfidir");
        //    return;
        //}
        //for (int i = 0; i < result.Length; i++)
        //{
        //    Console.Write($"result[{i + 1}]= ");
        //    Console.WriteLine(result[i]);
        //}
        #endregion
        
         #region task 9  

        //int[] x = Helper.FillArray(25, "x");

        //int[] pow = new int[0];
        //for (int i = 0; i < 8; i++)
        //{
        //    Array.Resize(ref pow, pow.Length + 1);
        //    pow[pow.Length - 1] = (int)Math.Pow(x[i], 2);
        //}
        //int[] partTwo = new int[0];
        //for (int i = 8; i < x.Length; i++)
        //{
        //    Array.Resize(ref partTwo, partTwo.Length + 1);
        //    partTwo[partTwo.Length - 1] = x[i] / 4;

        //}
        //for (int i = 0; i < pow.Length; i++)
        //{
        //    Console.Write($"pow[{i + 1}]= ");
        //    Console.WriteLine(pow[i]);
        //}
        //for (int i = 0; i < partTwo.Length; i++)
        //{
        //    Console.Write($"partTwo[{i + 1}]= ");
        //    Console.WriteLine(partTwo[i]);
        //}
        #endregion
        
         #region task 10
        //l1:
        //    Console.WriteLine("massivin uzunluqunu daxil edin:");
        //    if (!int.TryParse(Console.ReadLine(), out int len))
        //    {
        //        goto l1;
        //    }
        //    int[] arr = Helper.FillArray(len, "arr");

        //    int[] negativ = new int[0];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] < 0)
        //        {
        //            Array.Resize(ref negativ, negativ.Length + 1);
        //            negativ[negativ.Length - 1] = arr[i];


        //        }
        //    }
        //    if (negativ.Length == 0)
        //    {
        //        Console.WriteLine("menfi element yoxdur");
        //        return;
        //    }
        //    int max = negativ[0];
        //    for (int i = 0; i < negativ.Length; i++)
        //    {
        //        //Console.WriteLine(negativ[i]);
        //        if (max < negativ[i])
        //        {
        //            max = negativ[i];
        //        }
        //    }
        //    Console.WriteLine(max);
            #endregion

        }

    }
}