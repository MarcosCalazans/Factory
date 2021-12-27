using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Factory
{
    class geradorAlienSimples : geradorAlien
    {
        public override GameObject geraAlien()
        {
            Thread.Sleep(50);
            Random r = new Random();
            int temp = r.Next(1, 4);

            if (temp == 1) return new Alien1();
            if (temp == 2) return new Alien2();
            if (temp == 3) return new Alien3();

            return null;
        }
    }
}
