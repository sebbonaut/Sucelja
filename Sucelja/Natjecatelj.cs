using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja
{
    internal class Natjecatelj : IInfo, IUsporedivo
    {
        string ime, prezime, sifru;
        int[] bodovi;
        decimal Ukupno
        {
            get
            {
                int suma = 0;
                foreach (int i in bodovi) {
                    suma += i;
                }
                return suma;
            }
        }
        decimal Prosjek
        {
            get
            {
                if(bodovi.Length > 0)
                    return Ukupno / bodovi.Length;
                return 0;
            }
        }
        public Natjecatelj(string ime, string prezime,
            string sifru, int[] bodovi)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.sifru = sifru;
            this.bodovi = bodovi;
        }
        public bool Usporedi(object objekt)
        {
            if(objekt is Natjecatelj a)
            {
                return Prosjek <= a.Prosjek;
            }
            return false;
        }
        public string Id => sifru;
        public void KratkiInfo()
            => Console.WriteLine($"{sifru} {Prosjek}");
        public void Info()
            => Console.WriteLine($"{sifru} {ime} {prezime}\n" +
                $"\tUkupno: {Ukupno} bodova\n" +
                $"\tProsjek: {Prosjek:0.00} bodova po zadatku.");
    }
}
