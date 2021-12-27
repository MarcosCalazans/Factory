using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
    class AlienFactory
    {

        public static GameObject geraAlien()
        {
            Random r = new Random();

            int i = r.Next(1, 4);

            if (i == 1) return new Alien1();
            if (i == 2) return new Alien2();
            if (i == 3) return new Alien3();

            else return null;
        }

        public static GameObject geraSuperAlien()
        {
            Random r = new Random();

            int i = r.Next(1, 3);

            if (i == 1) return new SuperAlien();
            if (i == 2) return new SuperAlien2();
            //if (i == 3) return new Alien3();

            else return null;
        }

    }
}
