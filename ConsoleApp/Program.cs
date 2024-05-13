using ClassLibrary.Data;

LottoContext db = new LottoContext();


if (!db.Jatekos.Any())
{
    var sorok = File.ReadAllLines(@"C:\Users\PC\Desktop\gyakorlás\Forras\csv\jatekosok.csv").Skip(1);
    foreach (var line in sorok)
        db.Jatekos.Add(new ClassLibrary.Models.Jatekos(line));
    db.SaveChanges();   
}
if (!db.Tipp.Any())
{
    var sorok = File.ReadAllLines(@"C:\Users\PC\Desktop\gyakorlás\Forras\csv\tippek.csv").Skip(1);
    foreach (var line in sorok)
        db.Tipp.Add(new ClassLibrary.Models.Tipp(line));
    db.SaveChanges();
}