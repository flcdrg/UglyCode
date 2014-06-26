using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UglyCode.Lesson05
{
    interface ISolid
    {
        float Multiply(int x, int y);
        void Log(string message);
        int Sum(int x, int y);
        void DrawPicture(Bitmap bitmap);
        string Format(string message, params object[] args);
    }

    class Solid : ISolid
    {
        public int TaxRate { get; set; }

        public float Multiply( int x, int y )
        {
            using (var writer = new System.IO.StreamWriter(@"c:\tmp\logging.txt"))
            {
                writer.WriteLine(" x {0}, y {1}", x, y);
                float result = x * y;

                if (TaxRate <= 25)
                    result = result * 1.1f;
                else if (TaxRate <= 50)
                    result = result * 1.2f;

                return result;
            }
        }

        public void Log(string message) { }
        public int Sum(int x, int y) { return x + y; }
        public void DrawPicture(Bitmap bitmap) { }
        public string Format(string message, params object[] args) { return string.Format(message, args); }
    }

    class Liquid : ISolid
    {
        public float Multiply(int x, int y)
        {
            return x / y;
        }

        public void Log(string message) { }
        public int Sum(int x, int y) { return x + y; }
        public void DrawPicture(Bitmap bitmap) { }
        public string Format(string message, params object[] args) { return string.Format(message, args); }
    }
}
