using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling
{
    public class Television : IRemote
    {
        private static Television _television;
        static Television()
        {
            _television = new Television();
        }
       
        public static Television Instance
        {
            get
            {
                return _television;
            }
        }
        public void Run()
        {
           Console.WriteLine("Television is started");
        }
    }
}
