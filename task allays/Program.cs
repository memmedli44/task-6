namespace task_allays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 6
            //    l1:
            //    Console.WriteLine("massivlerin uzunluqunu daxil edin");

            //    if (!int.TryParse(Console.ReadLine(), out int len))
            //    { 

            //        goto l1;
            //    }
            //    int[] x = new int[len] ;
            //    int[] y = new int[len];
            //l2:
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        Console.Write($"x[{i + 1}]= ");
            //        if (!int.TryParse(Console.ReadLine(), out int array))
            //        {
            //            goto l2;
            //        }
            //        x[i] = array;
            //    }
            //l3:
            //    for (int i = 0; i < y.Length; i++)
            //    {
            //        Console.Write($"y[{i+1}]= ");
            //        if (!int.TryParse(Console.ReadLine(), out int array))
            //        {
            //            goto l3;
            //        }
            //        y[i] = array;
            //    }
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
            //    int[] x = new int[len];
            //l2:
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        Console.Write($"x[{i + 1}]= ");
            //        if (!int.TryParse(Console.ReadLine(), out int array))
            //        {
            //            goto l2;
            //        }
            //        x[i] = array;
            //    }
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
            //    double geoMean = Math.Pow(min * max, 1.0 / 2);
            //    Console.WriteLine($"ededi orta:{average} ");
            //    Console.WriteLine($"; hendesi orta:{geoMean}");
            #endregion

            #region task 8

            //    int[] x = new int[14];
            //    int[] y = new int[14];
            //l1:
            //    Console.WriteLine("elementleri daxil edin:");
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        Console.Write($"x[{i + 1}]= ");
            //        if (!int.TryParse(Console.ReadLine(), out int array))
            //        {
            //            goto l1;
            //        }
            //        Console.Write($"y[{i + 1}]= ");
            //        if (!int.TryParse(Console.ReadLine(), out int arrayTwo))
            //        {
            //            goto l1;
            //        }
            //        y[i] = arrayTwo;
            //        x[i] = array;
            //    }
            //int[] result = new int[0];
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        int sum = x[i] + y[i];
            //        if (sum >= 0)
            //        {
            //            Array.Resize(ref result, result.Length + 1);
            //                result[result.Length-1] = sum;
            //        }

            //    }
            //    for(int i=0;i<result.Length;i++)
            //    {
            //        Console.Write($"result[{i + 1}]= ");
            //        Console.WriteLine(result[i]);
            //    }
            #endregion

            #region task 9  
            //l1:
            //    Console.WriteLine("elementleri daxil edin");
            //    int[] x = new int[25];
            //    for (int i = 0; i < x.Length; i++)
            //    {
            //        Console.Write($"x[{i + 1}]= ");
            //        if (!int.TryParse(Console.ReadLine(), out int array))
            //        {
            //            goto l1;
            //        }
            //        x[i] = array;
            //    }
            //    int[] pow=new int[0];
            //    for(int i=0;i<8;i++) 
            //    {
            //        Array.Resize( ref pow, pow.Length+1 );
            //        pow[pow.Length - 1] = (int)Math.Pow(x[i], 2);



            //    }
            //    int[] partTwo=new int[0];
            //    for (int i = 8; i < x.Length; i++)
            //    {
            //        Array.Resize(ref partTwo,partTwo.Length+1 );
            //        partTwo[partTwo.Length - 1] = x[i]/4;

            //    }
            //    for (int i = 0; i < pow.Length; i++)
            //    {
            //        Console.Write($"pow[{i + 1}]= ");
            //        Console.WriteLine(pow[i]);
            //    }
            //    for (int i = 0; i < partTwo.Length; i++)
            //    {
            //        Console.Write($"partTwo[{i + 1}]= ");
            //        Console.WriteLine(partTwo[i]);
            //    }
            #endregion

            #region task 10
            //l1:
            //Console.WriteLine("massivin uzunluqunu daxil edin:");
            //if (!int.TryParse(Console.ReadLine(), out int len)) 
            //{
            //    goto l1;
            //}
            //int[] arr=new int[len];
            //l2:
            //Console.WriteLine("elementleri daxil edin:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"arr[{i + 1}]= ");
            //    if (!int.TryParse(Console.ReadLine(), out int array))
            //    {
            //        goto l2;
            //    }
            //    arr[i] = array;
            //}
            //int[] negativ=new int[0];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < 0)
            //    {
            //        Array.Resize(ref negativ,negativ.Length+1);
            //        negativ[negativ.Length-1] = arr[i];


            //    }
            //}
            //int max = negativ[0];
            //for (int i = 0; i < negativ.Length; i++)
            //{
            //    //Console.WriteLine(negativ[i]);
            //    if (max < negativ[i])
            //    {
            //        max = negativ[i];
            //    }
            //}
            //Console.WriteLine(max);
            #endregion

        }

    }
}