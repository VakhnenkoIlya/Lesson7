using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice2
{
    interface IMovable
    {
        public void MoveVertically(int deltaY);
        public void MoveGorizon(int deltaX);
    }
}
//1