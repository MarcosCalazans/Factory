using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Factory
{
    class geradorAlienSuper : geradorAlien
    {
        public override GameObject geraAlien()
        {
            Thread.Sleep(50);
            Random r = new Random();
            int temp = r.Next(1, 3);

            if (temp == 1) return new SuperAlien();
            if (temp == 2) return new SuperAlien2();
            

            return null;
        }
    }
}
