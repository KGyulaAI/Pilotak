namespace Pilotak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pilotak> pilotakLista = new List<Pilotak>();

            StreamReader streamReader = new StreamReader("pilotak.csv");
            streamReader.ReadLine();
            while (!streamReader.EndOfStream)
            {
                string[] pilotaAdatai = streamReader.ReadLine().Split(";");
                if (pilotaAdatai[3] == "")
                {
                    pilotakLista.Add(new Pilotak(pilotaAdatai[0], pilotaAdatai[1], pilotaAdatai[2]));
                }
                else
                {
                    pilotakLista.Add(new Pilotak(pilotaAdatai[0], pilotaAdatai[1], pilotaAdatai[2], int.Parse(pilotaAdatai[3])));
                }
            }
            streamReader.Close();

            Console.WriteLine($"3. feladat: {pilotakLista.Count}");
            Console.WriteLine($"4. feladat: {pilotakLista.Last().Nev}");
            Console.WriteLine("5. feladat: ");
            foreach (Pilotak pilota in pilotakLista)
            {
                if (int.Parse(pilota.SzuletesiDatum.Split(".")[0]) < 1901)
                {
                    Console.WriteLine($"\t{pilota.Nev} ({pilota.SzuletesiDatum})");
                }
            }

            Console.WriteLine($"6. feladat: {pilotakLista.OrderBy(p => p.Rajtszam).First().Nemzetiseg}");
            Console.WriteLine($"7. feladat: ");
        }
    }
}