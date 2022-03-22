using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_SOLID_Wrong
{
    public interface IRepository
    {
        void Update();
        void Create();
        void Remove(int id);
        void Get(int id);
        void GetAll();
    }
}
