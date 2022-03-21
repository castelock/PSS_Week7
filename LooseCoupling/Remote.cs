using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooseCoupling
{
    internal class Remote
    {
        IRemote _remote;
        public Remote(IRemote remote)
        {
            _remote = remote;
        }

        public void Run()
        {
            _remote.Run();
        }
    }
}
