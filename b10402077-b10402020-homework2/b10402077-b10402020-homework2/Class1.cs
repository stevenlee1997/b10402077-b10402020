using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b10402077_b10402020_homework2
{
    class Class1
    {
        public int RandomNum()
        {
            Random num = new Random();
            return num.Next(0, 100);
        }
    }
}
