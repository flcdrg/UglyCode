using System;
using System.Threading;
using System.Threading.Tasks;

namespace UglyCode.Lesson07
{
    public class Tasks
    {
        public static void Main()
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

            One();
            Two();
            Three();
            Four();
            Five();
            Six();
            Seven();
            Eight();

            Console.ReadLine();
        }

        private static void One()
        {
            var t = new Task(() => Console.WriteLine(Thread.CurrentThread.ManagedThreadId));
        }

        private static void Two()
        {
            var t = new Task(() => Console.WriteLine("Two {0}", Thread.CurrentThread.ManagedThreadId));

            t.Start(TaskScheduler.Current);
        }

        private static void Three()
        {
            var t = new Task(() => Console.WriteLine("Three {0}", Thread.CurrentThread.ManagedThreadId));

            t.RunSynchronously();
        }

        private static void Four()
        {
            Task.Run(() => Console.WriteLine("Four {0}", Thread.CurrentThread.ManagedThreadId));
        }

        private static void Five()
        {
            Task.Factory.StartNew(() => Console.WriteLine("Five {0}", Thread.CurrentThread.ManagedThreadId));
        }

        private static void Six()
        {
            Task.Factory.StartNew(() => Console.WriteLine("Six {0}", Thread.CurrentThread.ManagedThreadId));
        }

        private static void Seven()
        {
            Console.WriteLine("Before");
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(20);
                Console.WriteLine("Seven {0}", Thread.CurrentThread.ManagedThreadId);
            });
            Console.WriteLine("After");
        }

        private static async void Eight()
        {
            Console.WriteLine("Before");
            await Task.Factory.StartNew(() =>
            {
                Thread.Sleep(20);
                Console.WriteLine("Eight {0}", Thread.CurrentThread.ManagedThreadId);
            });
            Console.WriteLine("After");
        }
    }
}
