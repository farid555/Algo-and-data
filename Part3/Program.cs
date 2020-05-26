using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace part3 
{
    
        
  class Program
  {
    public static int[] Randomizer(int n)
    {
      Random random = new Random();
      int[] arr = new int[n];
      for (int i = 0; i < arr.Length; i++)
      {
        // integers between 1 and 1000 are enough for us
        arr[i] = random.Next(1, 1001);
      }
      return arr;
    }

     static void Main(string[] args){
      
        SmallestDifference s = new SmallestDifference();
       Console.WriteLine(s.Calculate(new int[] { 4, 1, 8, 5 })); // 1
       Console.WriteLine(s.Calculate(new int[] { 1, 10, 100 })); // 9
       Console.WriteLine(s.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 0
       Console.WriteLine(s.Calculate(Randomizer(11))); // depends on random

      

      

    }
  }
  
}

        
             //exercise1
            //PrintHello printHello = new PrintHello();
            //printHello.Hello(8);
            
            //Console.WriteLine();


            /*
            exercise4
            BinarySearch b = new BinarySearch ();
            Console.WriteLine (b.Find ((new int[] { 4, 1, 8, 5 }), 2)); // false
            Console.WriteLine (b.Find ((new int[] { 0, 0 }), 0)); // true
            Console.WriteLine (b.Find ((new int[] { 4, 1, 8, 5, 8, 7, 4, 2, 3 }), 2)); // true
            Console.WriteLine (b.Find ((new int[] { 0 }), 0)); // true
            Console.WriteLine();
            Console.WriteLine (b.Find ((Randomizer (1000)), 3)); // ?
        }*/
     