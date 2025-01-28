using System;

class task2
{
    static void Main()
    {
        int []arr = {123, 124, 132, 156, 198, 144};

        // 3 * 4 * 2 * 6 * 8 * 4 = 4608
        // 2 * 2 * 3 * 5 * 9 * 4 = 2160
        // 1 * 1 * 1 * 1 * 1 * 1 = 1
        int []ans = {0, 0, 0};
        for(int i = 0; i < 3; i++)
        {
            int temp = 1;
            for(int j = 0; j < 6; j++)
            {
                int rem = arr[j] % 10;
                temp = temp * rem;
                arr[j] /= 10;
            }
            ans[3 - i - 1] = temp;
        }
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine(ans[i]);
        }
    }
}