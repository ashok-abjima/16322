using System;

class Program
{
    int[] ar = { 1, 2, 3, 4 };
    int[] ar2 = { 5, 6, 7, 8 };
    int c = 0;
    int[] ar3 = new int[4];


    public void swp()
    {
       // Console.Write("Sum of Arrays indexes : ");
        for (int i = 0; i < ar.Length; i++)
        {
            c = ar[i] + ar2[i];
            ar3[i] = c;
            // Console.WriteLine("INDEX " + i + " : " + c + " ");

        }
        //Console.ReadKey();
        



    }
    public void printarrar3()
    {

        for (int i = 0; i < ar3.Length; i++)
        {
            Console.WriteLine(" Array is {0}", ar3[i]);
           

        }
        Console.ReadKey();
    }


    class smar
    {
        public static void Main()
        {
            Program ob = new Program();
            ob.swp();
            ob.printarrar3();


        }
    }





}
