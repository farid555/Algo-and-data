using System;
namespace part3 {
    class Program {
        public static void Main (string[] args) {

            //PrintHello printHello = new PrintHello();
            //printHello.Hello(8);
            
            //Console.WriteLine();


            BinarySearch b = new BinarySearch ();
            Console.WriteLine (b.Find ((new int[] { 4, 1, 8, 5 }), 2)); // false
            Console.WriteLine (b.Find ((new int[] { 0, 0 }), 0)); // true
            Console.WriteLine (b.Find ((new int[] { 4, 1, 8, 5, 8, 7, 4, 2, 3 }), 2)); // true
            Console.WriteLine (b.Find ((new int[] { 0 }), 0)); // true
            Console.WriteLine();
            Console.WriteLine (b.Find ((Randomizer (1000)), 3)); // ?
        }
        public static int[] Randomizer (int n) {
            Random random = new Random ();
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++) {
                // integers between 1 and 1000 are enough for us
                arr[i] = random.Next (1, 1001);
            }
            return arr; 
        }
    }

}