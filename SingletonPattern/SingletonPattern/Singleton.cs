using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonPattern
{
    class Singleton
    {

        private Singleton instance;

        private Singleton() { }

        public static synchronized Singleton getInstance() {
        }
    }
}
