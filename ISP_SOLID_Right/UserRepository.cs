using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_SOLID_Right
{
    internal class UserRepository : IReadable, IWriteable, IRemovable
    {
        public void Create() { }
        public void Update() { }
        public void Remove(int id) { }
        public void Get(int id) { }
        public void GetAll() { }
    }
}
