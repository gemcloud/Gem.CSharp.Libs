using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    //
    public sealed class Singleton
    {
        // Fields
        private static Singleton _instance = null;
        // constructure 
        private Singleton() { }
        // Properties
        public static Singleton Instance
        {
            get
            {
                if (_instance ==  null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
        // Methods
        public string DoSomething(string inStr)
        {
            return inStr;
        }
    }

    // 
    public sealed class SingletonStaticSafe
    {
        private static readonly SingletonStaticSafe instance = new SingletonStaticSafe();
        private SingletonStaticSafe() { }
        // Explicit static constructor to tell C# compiler
        static SingletonStaticSafe() { }

        public SingletonStaticSafe Instance
        {
            get {
                return instance; // new SingletonStaticSafe();
            }
        }

        public string DoSomething(string inStr)
        {
            return inStr;
        }

    }

}
