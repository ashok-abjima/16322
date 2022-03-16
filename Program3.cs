using System;

class Program
{
    int [] ar = {5,8,7,45,25,16};
  

    public void max()
    {
        int c = ar[0];
       
            for (int j=1;j<ar.Length;j++)
            {
                if (c > ar[j])
                {
                    
                }
                else
                {
                    c = ar[j];
                }
                    
                    
            }
        
        Console.WriteLine("Max Number is {0} ",c);
        Console.ReadKey();
    }
}
class maxx
{
    public static void Main()
    {
       Program obj = new Program();
        obj.max();
        

    }
}