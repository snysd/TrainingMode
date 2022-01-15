using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingMode
{
    class HighLowCard
    {
        public static void method()
        {
            string[] ParentCard = Console.ReadLine().Trim().Split(' ');
            var PC1 = Int32.Parse(ParentCard[0]);
            var PC2 = Int32.Parse(ParentCard[1]);

            var cnt = Int32.Parse(Console.ReadLine().Trim());
            string ans = null;
            for (var c = 0; c < cnt; c++)
            {
                string[] ChildCard = Console.ReadLine().Trim().Split(' ');
                if (PC1 > Int32.Parse(ChildCard[0]))
                {
                    ans += "High ";
                }
                else if (PC1 == Int32.Parse(ChildCard[0]))
                {
                    if (PC2 < Int32.Parse(ChildCard[1]))
                    {
                        ans += "High ";
                    }
                    else ans += "Low ";
                }
                else ans += "Low ";
            }
            string[] strAns = ans.Split(' ');
            foreach (var StrAns in strAns)
            {
                Console.WriteLine(StrAns);
            }
        }
    }
}
