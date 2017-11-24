using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b10402077_b10402020_homework2
{
    class Class2
    {
        public bool PrimeNum(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }

            return true;

        }
    }
}
