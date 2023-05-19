using pilotak;
using System.Text;


List<Pilotak> pilotak = new List<Pilotak>();


StreamReader sr = new StreamReader("pilotak.csv");
sr.ReadLine();
while (!sr.EndOfStream)
{
    string[] adat = sr.ReadLine().Split(';');
    pilotak.Add(new Pilotak(adat[0], adat[1], adat[2], (adat[3].Length > 0) ? int.Parse(adat[3]) : 0));
}
sr.Close();

Console.WriteLine($"3. feladat: {pilotak.Count()}");

Console.WriteLine($"4. feladat: {pilotak.Last().VersenyzoNev}");

Console.WriteLine("5. feladat:");
pilotak.Where(x => DateTime.Parse(x.VersenyzoSzuletes) > DateTime.Parse("1991.01.01.")).ToList().ForEach(x => Console.WriteLine(x.VersenyzoNev));

Console.WriteLine($"6. feladat: {pilotak.Where(x => x.VersenyzoRajtszam != 0).OrderBy(x => x.VersenyzoRajtszam).First().VersenyzoNemzetiseg}");

Console.WriteLine($"7. feladat:");