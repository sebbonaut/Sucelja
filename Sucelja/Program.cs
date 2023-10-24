using Sucelja;

internal class Program
{
    private static void Main(string[] args)
    {
        AkcijskiArtikl a = new(1.55M, 0.4M, "123", "Gris",0.2M),
               b = new(1.35M, 0.4M, "234", "Krumpirov kruh", 0.3M);
        IUsporedivo c = a;
        IInfo e = a;
        //e.Info();
        Artikl d = (Artikl)c;

        Artikl[] nizArtikala =
        {
            a,
            b,
            new Artikl(1.39M, 0.064M, "132", "Alpska juha"),
            new Artikl(4.69M, 0.5M, "100", "Kikiriki slani"),
            new Artikl(0.99M, 0.275M, "002", "Lisnato tijesto")
        };
        Sortiraj(nizArtikala);
        IspisSvih(nizArtikala);

        Natjecatelj[] natjecatelji =
        {
            new Natjecatelj("Ivo","Ivic","123", new int[] {2,1,4}),
            new Natjecatelj("Bob","Doe","312", Array.Empty<int>()),
            new Natjecatelj("Larry","Jane","432", new int[] {4,3})
        };
        Console.WriteLine("----NATJECATELJI:----");
        Sortiraj(natjecatelji);
        IspisSvih(natjecatelji);

        static void Sortiraj(IUsporedivo[] niz)
        {
            for (int i = 0; i < niz.Length - 1; i++)
                for (int j = i + 1; j < niz.Length; j++)
                {
                    if (!niz[i].Usporedi(niz[j]))
                    {
                        IUsporedivo temp = niz[i];
                        niz[i] = niz[j];
                        niz[j] = temp;
                    }
                }
        }

        static void IspisSvih(IInfo[] niz)
        {
            foreach (IInfo n in niz)
            {
                n.Info();
            }
        }
    }
}