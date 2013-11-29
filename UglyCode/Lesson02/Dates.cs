using System;

namespace UglyCode.Lesson02
{
    public class Dates
    {
        public static void Main()
        {
            DateTime d1 = new DateTime();

            DateTime d2 = DateTime.Now;

            DateTime d3 = DateTime.UtcNow;

            DateTimeOffset d4 = DateTime.Now;

            DateTimeOffset d5 = DateTime.UtcNow;

            DateTimeOffset d6 = DateTimeOffset.Now;

            DateTimeOffset d7 = DateTimeOffset.UtcNow;
        } 
    }
}