using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int fases = 1;
            GameObject[] aliens = new GameObject[10];
            geradorAlien factory = new geradorAlienSimples();

            // init
            for (int i = 0; i < aliens.Length; i++)
                aliens[i] = factory.geraAlien();

            while (fases < 3)
            {
                // entrada do usuário

                //atualização lógica
                for (int i = 0; i < aliens.Length; i++)
                    aliens[i].logica();

                //atualização visual
                for (int i = 0; i < aliens.Length; i++)
                    aliens[i].visualizar();


                Console.ReadKey();
                Console.Clear();
                fases++;

                Console.WriteLine("Fase "+ fases);
                factory = new geradorAlienSuper();

                for (int i = 0; i < aliens.Length; i++)
                    aliens[i] = factory.geraAlien();
            }
        }
    }
}
