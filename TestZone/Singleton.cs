using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestZone
{
    public sealed class Singleton
    {
        private static Singleton _Instance = null;
        private static readonly object padlock = new object();

        Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if(_Instance == null)
                    {
                        _Instance = new Singleton();
                    }
                    return _Instance;
                }
            }
        }
    }

    public sealed class Singleton2
    {
        //Thread safe without using lock
        private static readonly Singleton2 instance = new Singleton2();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton2()
        {
        }

        private Singleton2()
        {
        }

        public static Singleton2 Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
