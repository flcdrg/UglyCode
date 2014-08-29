using System;
using System.Threading.Tasks;

namespace UglyCode.Lesson07
{
    public class Tasks
    {
        public static void Main()
        {
            Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId);

            One();

            Two();

            Three();

            Four();

            Five();

            Six();

            Console.ReadLine();
        }

        private static void One()
        {
            var t = new Task(() => Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId));
        }

        private static void Two()
        {
            var t = new Task(() => Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId));

            t.Start(TaskScheduler.Current);
        }

        private static void Three()
        {
            var t = new Task(() => Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId));

            t.RunSynchronously();
        }

        private static void Four()
        {
            Task.Run(() => Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId));
        }

        private static void Five()
        {
            Task.Factory.StartNew(() => Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId));
        }

        private static void Six()
        {
            Task.Factory.StartNew(() => Console.WriteLine(System.Threading.Thread.CurrentThread.ManagedThreadId));
        }
    }
}
