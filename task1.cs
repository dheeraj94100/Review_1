using System;

class Task1
{
    static void Main()
    {
        int a = 123456;
        // 1 ^ 5 + 2 ^ 4 + 3 ^ 3 + 4 ^ 2 + 5 ^ 1 + 6 ^ 0 = 1 + 16 + 27 + 16 + 5 + 1 = 66
        int b = a;
        int pow = 0;
        int sum = 0;
        while(a > 0)
        {
            int rem = a % 10;
            sum += (int)Math.Pow(rem, pow);
            a /= 10;
            pow++;
        }
        Console.WriteLine("Sum of digits of {0} raised to the power of their position is {1}", b, sum);
    }
}