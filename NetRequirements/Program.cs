using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Insert size of ZAGOTOVKA: ");
        int coloda = Convert.ToInt32(Console.ReadLine());
        int newColoda;
        Console.WriteLine("Insert number of sizes: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int bnk;
        int test = 1;
        var sizes = new List<int>();
        int size;
        var bolvanka = new List<int>();
        var allBolvankies = new List<int>();
        for (int i = 1; i <= n; i++)
        {

            Console.WriteLine("Insert number of bolvanok sizes " + i + ": " + n);
            bnk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert size of bolvanok sizes " + i + ": " + n);
            size = Convert.ToInt32(Console.ReadLine());
            //sizes.Add(bnk);
            for (int b = 1; b <= bnk; b++)

            {
                sizes.Add(b);
                allBolvankies.Add(size);
               // Console.WriteLine("Size Bolvanok  " + size);
            }
        };
        {
          //  Console.WriteLine("Max of Collection:  " + allBolvankies.Max());
          //  Console.WriteLine("Number of Collection:  " + allBolvankies.Count);
            allBolvankies.Sort();
            allBolvankies.Reverse();
            newColoda = coloda; //Reverse
            foreach (int k in allBolvankies)
            {
                newColoda = newColoda - k;
                //Console.WriteLine("\n " + k + " coloda " + newColoda);
                if (newColoda < k || k < allBolvankies.Min() || newColoda < 0)
                {
                    test++;
                    newColoda = coloda;
                  //  Console.WriteLine(" ZERO " + test);
                    continue;
                }
            }
            Console.WriteLine(" RESULT \n You need: " + test);
        }
    }
}
