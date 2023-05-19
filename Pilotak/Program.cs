namespace Pilotak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pilotak> pilotakLista = new List<Pilotak>();

            StreamReader streamReader = new StreamReader("pilotak.csv");
            streamReader.ReadLine();
            string sor;
            while ((sor = streamReader.ReadLine()) != null)
            {
                pilotakLista.Add();
            }
            streamReader.Close();
            Pilotak pilotak = new Pilotak(streamReader);
        }
    }
}