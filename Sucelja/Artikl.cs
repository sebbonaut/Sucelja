using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja
{
    internal class Artikl : IUsporedivo, IInfo
    {
        decimal cijena, tezina;
        string barkod, naziv;
        public Artikl(decimal cijena, decimal tezina, 
            string barkod, string naziv)
        {
            this.cijena = cijena;
            this.tezina = tezina;
            this.barkod = barkod;
            this.naziv = naziv;
        }
        private decimal CijenaPoKg
            => cijena / tezina;
        public bool Usporedi(object objekt)
        {
            if(objekt is Artikl a)
            {
                return CijenaPoKg <= a.CijenaPoKg;
            }
            return false;
        }
        public string Id => barkod;
        public void KratkiInfo()
            => Console.WriteLine($"{naziv} za {cijena} EUR");
        public virtual void Info()
            => Console.WriteLine($"{barkod} {naziv}\n" +
                $"\ttezina: {tezina:0.000} kg\n" +
                $"\tcijena: {cijena:0.00} EUR\n" +
                $"\tpo kg: {CijenaPoKg:0.00} EUR/kg");
    }
    internal class AkcijskiArtikl : Artikl
    {
        public override void Info()
        {
            base.Info();
            Console.WriteLine("\tDodatan popust od " +
                $"{Math.Round(popust * 100, 2)}%");
        }
        decimal popust;
        public AkcijskiArtikl(decimal cijena, decimal tezina,
            string barkod, string naziv, decimal popust)
            : base(cijena, tezina, barkod, naziv)
                => this.popust = popust;
    }
}
