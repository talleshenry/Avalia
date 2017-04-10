using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalia.Model
{
    class SingletonJanelas
    {

        private static SingletonJanelas instance;

        private SingletonJanelas() { }

        internal static SingletonJanelas Instance
        {
            get
            {
                if (instance ==null) {
                    instance = new SingletonJanelas();
                }
                return instance;
            }

            set
            {
                instance = value;
            }
        }
    }
}
