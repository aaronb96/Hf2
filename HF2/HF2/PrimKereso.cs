using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HF2
{
    class PrimKereso
    {
        public static bool PrimeSearcher(int szam)
        {
            bool prime = false;
            int db = 0;
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    db++;
                }
            }
            prime = db == 2;
            return prime;
        }
    }
}
