using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lutrija
{
    class Loto
    {
        private List<int> UplaceniBrojevi { get; set; }
        private List<int> DobitniBrojevi { get; set; }

        /// <summary>
        /// Konstruktor klase
        /// </summary>
        public Loto()
        {
            UplaceniBrojevi = new List<int>();
            DobitniBrojevi = new List<int>();
        }


        public bool UnesiUplaceneBrojeve(List<string> korisnickeVrijednosti)
        {
            bool ispravni = false;
            UplaceniBrojevi.Clear();

            foreach (string v in korisnickeVrijednosti)
            {
                int broj = 0;
                if (int.TryParse(v, out broj) == true)
                {
                    if (broj >= 1 && broj <= 39)
                    {
                        if (UplaceniBrojevi.Contains(broj) == false)
                        {
                            UplaceniBrojevi.Add(broj);
                        }
                    }
                }
            }
            if (UplaceniBrojevi.Count == 7)
            {
                ispravni = true;
            }


            return ispravni;
        }

        public void GenerirajDobitnuKombinaciju()
        {
            DobitniBrojevi.Clear();

            Random generiraj = new Random();

            while (DobitniBrojevi.Count <7)
            {
                int broj = generiraj.Next(1, 39);
                if (DobitniBrojevi.Contains(broj) == false)
                {
                    DobitniBrojevi.Add(broj);
                }
            }

        }

        public int IzracunajBrojPogodaka()
        {
            int pogodak = 0;

            foreach (int broj in UplaceniBrojevi)
            {
                if (DobitniBrojevi.Contains(broj) == true)
                {
                    pogodak++;
                }
            }
            return pogodak;
        }  

    }
}
