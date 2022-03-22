using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_SOLID_Right
{
    public interface IReadable
    {
        void Get(int id);
        void GetAll();
    }
}
