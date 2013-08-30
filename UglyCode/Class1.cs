using UglyCode.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UglyCode
{
    public abstract class Class1
    {
        public int TimeStamp;

        private string _name = "";

        public Class1()
        {
            
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        private Int64 Converter( Int64 number )
        {
            return number*2;
        }
        public void Useful()
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="machineId"></param>
        /// <param name="remote"></param>
        public void Builder( int machineId, int remoteId )
        {
            List<string> list = new List<string>();



            list.Add( "Test1" );
            list.Add( "Test2" );
            list.Add( "Test3" );

            List<string> matches = new List<string>();
            for ( int i = 0; i < list.Count; i++ )
            {
                if ( list[ i ] == "Test2" )
                    matches.Add(list[i]);

            }
            
        }

        public string PrepareQuery(string name)
        {
            return "SELECT * FROM table WHERE name = '" + name + "'";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString() {
            return base.ToString() + _name;
        }
    }
}
