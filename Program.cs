namespace solsysdoga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bolygo = new List<Bolygok>();
            using(var sr = new StreamReader(@"..\..\..\src\solsys.txt"))
            {
                while (!sr.EndOfStream) bolygo.Add(new Bolygok(sr.ReadLine()));
            }

            Console.WriteLine("3. Feladat:");
            Console.WriteLine($"3.1: {bolygo.Count} bolygó van a naprendszerben");

            Console.WriteLine($"3.2: a naprendszerben egy bolygónak átlagosan {bolygo.Average(b => b.HoldSzama)} holdja van");

            var terfogat = bolygo.SingleOrDefault(b => b.Arany == bolygo.Max(b2 => b2.Arany));
            Console.WriteLine($"3.3: a legnagyobb térfogatú bolygó a {terfogat.Nev}");

            Console.Write("3.4: írd be a keresett bolygó nevét: ");
            var sor = Console.ReadLine();
            Console.WriteLine(bolygo.SingleOrDefault(b => b.Nev == sor) != null ? "Van ilyen bolygó a naprendszerben" : "Nincs ilyen bolygó a naprendszerben");

            Console.WriteLine("3.5: Írj be egy egész számot: ");
            var szam = int.Parse(Console.ReadLine());
            var holdak = bolygo.Where(b => b.HoldSzama > szam).Select(b => b.Nev).ToArray();
            Console.WriteLine($"a következő bolygónak/bolygóknak van {szam}-nál/nél több holdja: ");
            foreach (var item in holdak)
            {
                Console.Write($"{item},");
            }
        }
    }
}