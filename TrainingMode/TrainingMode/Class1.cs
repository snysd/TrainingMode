using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingMode
{
    class Class1
    {
        public static void Elevator()
        {
            int N = Int32.Parse(Console.ReadLine());
            int[] Array = new int[N];
            for (var i = 0; i < N; i++)
            {
                Array[i] = Int32.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (var i = 0; i < N; i++)
            {
                int M = 0;
                int m = 0;
                if (i == 0) m = 1;
                else m = Array[i - 1];
                M = m - Array[i];
                if (M < 0) M = M * (-1);
                sum += M;
            }
            Console.WriteLine(sum);
        }
    }
}
