using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TightCoupling
{
    public class Remote
    {
        private Television Tv { get; set; }
        protected Remote()
        {
            Tv = new Television();
        }

        static Remote()
        {
            _remoteController = new Remote();
        }
        static Remote _remoteController;
        public static Remote Control
        {
            get
            {
                return _remoteController;
            }
        }

        public void RunTv()
        {
            Tv.Start();
        }
    }
}
