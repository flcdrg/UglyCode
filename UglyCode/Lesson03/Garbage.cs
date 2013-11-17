using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Timers;
using System.Xml;

namespace UglyCode.Lesson03
{
    public class Garbage
    {
        private Timer _timer;
        private IntPtr _unmanagedResource;

        public Garbage()
        {
            _timer = new Timer() { Interval = 500, Enabled = false };
            _timer.Elapsed += TimerOnElapsed;
        }

        private void TimerOnElapsed( object sender, ElapsedEventArgs elapsedEventArgs )
        {
        }

        public SqlConnection ConnectionFactory()
        {
            return new SqlConnection();
        }

        public void Main()
        {
            var connection = ConnectionFactory();

            var pen = new Pen( Brushes.Azure );

            var brush = Brushes.Black;

            for ( int i = 0; i < 10; i++ )
            {
                var reader = XmlReader.Create( new StreamReader( string.Format( "data{0}.xml", i ) ));
                // ..
            }
        }
    }
}
