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

Console.WriteLine($"3. feladat: {pilotak.Count}");
