using System;
using System.Collections.Generic;
using System.Linq;

namespace UglyCode.Lesson04
{
    public class OperatorsDebugging
    {
        public static void Main()
        {
            int i = 1;
            int j = 2;

            float f = 1.23401234f;
            double w = 1.23401234d;
            Decimal d = 2.46802468m;

            Console.WriteLine(i);

            Console.WriteLine(i + j);

            Console.WriteLine(++i);

            Console.WriteLine(i++);

            Console.WriteLine(i++ + j++);

            Console.WriteLine(++i + ++j);

            Console.WriteLine(f * 2 == (double)d);
            Console.WriteLine("{0} {1}", f * 2, (double)d);

            Console.WriteLine((decimal)f * 2 == d);
            Console.WriteLine("{0} {1}", (decimal)f * 2, d);

            Console.WriteLine(f == w);
            Console.WriteLine("{0} {1}", f, w);

            Console.WriteLine("{0} {0}", i, j);

            Console.Read();
        }
    }
}