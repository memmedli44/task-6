namespace task_allays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            //Console.Write("Massivi daxil edin-");
            //int mas = int.Parse(Console.ReadLine());
            //int[] massiv = new int[mas];
            //bool silsiledir = true;
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    Console.Write($"Massiv[{i}]=");
            //    massiv[i] = int.Parse(Console.ReadLine());

            //}
            //int silsile1;
            //int silsile = (int)(massiv[1] - massiv[0]);
            //for (int i = 1; i < massiv.Length - 1; i++)

            //{
            //    silsile1 = (int)(massiv[i + 1] - massiv[i]);
            //    if (silsile != silsile1)
            //    {
            //        Console.WriteLine("Massiv ededi silsile deyil");
            //        silsiledir = false;
            //        break;
            //    }
            //    if (silsiledir)
            //        Console.WriteLine("Massiv ededi silsiledir");

            //}      
            #endregion

            #region  Massivde tek ededlerin siyahisi
            //Console.Write("Massivi daxil edin: ");
            //int mass = int.Parse(Console.ReadLine());
            //int[] massiv = new int[mass];

            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    Console.Write($"Massiv[{i}]=");
            //    massiv[i] = int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i <massiv.Length; i++)
            //{
            //    if (massiv[i]%2==1)
            //    {
            //        Console.WriteLine(massiv[i]);
            //    }
            //}
            #endregion

            #region Massivdeki menfi ededi tapmaq 
            //Console.Write("Massivin sayini daxil edin: ");
            //int mass = int.Parse(Console.ReadLine());
            //int[] massiv = new int[mass];
            //bool musbet = true;

            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    Console.Write($"Massiv[{i}]=");
            //    massiv[i] = int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    if (massiv[i] * -1 > massiv[i])
            //    {
            //        Console.WriteLine(massiv[i]);
            //        musbet = false;
            //        break;

            //    }


            //}
            //if (musbet)
            //{
            //    Console.WriteLine("Massivdeki butun ededler musbetdir.");
            //}
            #endregion

            #region kvadrat kokun tam eded olub olmamasini yoxlamaq
            //Console.Write("Massivin sayini daxil edin: ");
            //int mass = int.Parse(Console.ReadLine());
            //int[] massiv = new int[mass];
            //bool kokalti = false;

            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    Console.Write($"Massiv[{i}]=");
            //    massiv[i] = int.Parse(Console.ReadLine());

            //}
            //  for (int i = 0; i < massiv.Length; i++)
            //  {
            //    double kok = (double)Math.Sqrt(massiv[i]);
            //    if (kok % 1 == 0)
            //    {

            //        Console.WriteLine($"Massif[{i}]= {massiv[i]}");
            //        kokalti = true;


            //    }

            //    else 

            //    {
            //        Console.WriteLine($"Massiv[{i}]= {massiv[i]} Kvadrat koku tam eded deyil");
            //    }



            //  }
            #endregion

            #region massivin elementlerini tersine yazmaq
            //Console.Write("Massivin sayini daxil edin: ");
            //int mass = int.Parse(Console.ReadLine());
            //int[] massiv = new int[mass];

            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    Console.Write($"Massiv[{i}]=");
            //    massiv[i] = int.Parse(Console.ReadLine());


            //}

            //    Array.Reverse(massiv);
            //    Console.WriteLine("Reversed massiv: [{0}]",  string.Join(", ", massiv));

            #endregion

            #region 2 olculu massiv
            //Console.WriteLine("Massivin sutunlarinin sayini daxil edin:");
            //int sutun = int.Parse(Console.ReadLine());
            //Console.WriteLine("Massivin setirlerinin sayini daxil edin:");
            //int setir = int.Parse(Console.ReadLine());
            //int[,] massiv = new int[(sutun), (setir)];

            //for (int i = 0; i < sutun; i++)
            //{
            //    for (int j = 0; j < setir; j++)
            //    {
            //        Console.Write($"Massiv[{i},{j}]=");
            //        massiv[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < sutun; i++)
            //{
            //    int max = massiv[i, 0];
            //    for (int j = 0; j < setir; j++)
            //    {
            //        if (massiv[i, j] > max)
            //        {
            //            max = massiv[i, j];
            //        }
            //    }
            //    Console.WriteLine($"Sutun {i}'nin en buyuk elementi: {max}");
            //}

            #endregion
        }
    }
}