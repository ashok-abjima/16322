using System;

class Program
{
    int[] ar = { 1, 2, 3, 4 };
    int[] ar2 = { 5, 6, 7, 8 };
    int c = 0;


    public void swp()
    {
        Console.Write("Sum of Arrays indexes : ");
        for (int i = 0; i < ar.Length; i++)
        { 
        c = ar[i] + ar2[i];
        Console.WriteLine("INDEX "+i+" : "+c+" ");
       
    }
        Console.ReadKey();
    }
    class smar
    {
        public static void Main()
        {
            Program ob = new Program();
          ob.swp();
           

        }
    }
       


        

}
