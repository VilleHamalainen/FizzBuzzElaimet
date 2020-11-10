using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemainderElaimet
{
    class Elaintenlajittelija
    {
        static void Main(string[] args)
        {
            int[] taulukko = new int[40];
            Kissa kisse = new Kissa();
            List<Kissa> kissaLista= new List<Kissa>();
            List<Elaintenlajittelija> elainLista = new List<Elaintenlajittelija>();
            Vuoro();
            Jakojaannos();
            
         
               
             Console.ReadKey();
        }

        private static void Jakojaannos()
        {
            int maara = 50;
            for (int i = 1; i <= maara; i++)
            {

                if ((i % 4) == 0)
                {
                    Console.WriteLine("Hevonen");
                }
                else if ((i % 3) == 1)
                {
                    Console.WriteLine("Kissa");
                }
                else if ((i % 3) == 2)
                {
                    Console.WriteLine("Koira");
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("Papukaija");
                }
            }

        }
        private static void Vuoro()
        {
            int elainVuoro = 1;
            int taulukonPituus = 15;
            // Kissa, koira, papukaija, hevonen
            for (int i = 1; i < taulukonPituus; i++)

                // kun neljällä jaollinen, niin pitää olla hevonen
                // 1 mod 3 = 1, koska 0 + 0 * 3 + m = 1, joten m = 1
                // 2 mod 3 =2, koska 0 + 0 * 3 + m = 2, joten m = 2
                if ((i % 4) == 0)
                {
                    Console.WriteLine("Olen hevonen");

                    elainVuoro++;

                    if (elainVuoro == 4)

                    {
                        elainVuoro = 1;
                    }
                }
                else if (elainVuoro == 1)
                {
                    Console.WriteLine("Olen kissa");
                    elainVuoro++;
                }

                else if (elainVuoro == 2)
                {
                    Console.WriteLine("Olen koira");
                    elainVuoro++; // = 3
                }
                else if (elainVuoro == 3)
                {
                    Console.WriteLine("Olen papukaija");
                    elainVuoro = 1;
                }
        }

        public class Kissa
        {
            string nimi;
            int ika;

            public Kissa()
            {
                nimi = "Jesse";
                ika = 20;

            }

            public Kissa(string pNimi, int pIka)
            {
                this.nimi = pNimi;
                this.ika = pIka;

            }
        }

    }
    
}
