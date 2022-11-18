using System;

namespace AcumaticaTest
{
    public class FunctionAcumatica
    {
        static void Main()
        {
        }

        /// <summary>
        /// Main required function returns TRUE of FALSE based on the following requirements.
        /// If C= 0, then possible values of A and B are: А >= 14, В >= 14
        /// If C> 0, then possible values of А and В are: А > 2*(C+1),В > 2*(C+1)
        /// </summary>
        /// <param name="c"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool Function(int c, int b, int a)
        {
            Console.WriteLine($"c = {c}, a = {a}, b = {b} ");

            if (c == 0)
            {
                if (a >= 14 && b >= 14)
                {
                    Console.WriteLine($"When int c = {c} then a and b must be >=14, what is true");
                    return true;
                }
                else
                {
                    Console.WriteLine($"When int c = {c} then a and b must be >=14, what is false");
                    return false;
                }
            }
            else if (c > 0)
            {
                int temp = 2 * (c + 1);
                if (a > temp && b > temp)
                {
                    Console.WriteLine($"When int c > 0 and equal {c}, a and b must be more than {temp}, what is true");
                    return true;
                }
                else
                {
                    Console.WriteLine($"When int c > 0 and equal {c}, a and b must be more than {temp}, what is false");
                    return false;
                }
            }
            else Console.WriteLine($" Int c = {c}, which is < 0, not right condition");
            return false;
        }

    }
}
