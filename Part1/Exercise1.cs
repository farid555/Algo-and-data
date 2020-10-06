using System;
namespace Part1

{
    public class Numbers
    {
        public int Sum(int x)
        {
            x = Math.Abs(x);
            int sum = 0;

            while (x != 0)
            {

                sum += x % 10;  //sum = sum + x % 10
                x /= 10; // x = x/10
            }
            return sum;
        }
    }
}