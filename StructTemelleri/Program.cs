internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ders Tanımlama : ");
        // Tanımlama
        Ders ders1 = new Ders();
        ders1.Id = 1;
        ders1.Name = "Tarih";
        ders1.Kredisi = 2;
        Console.WriteLine(ders1.Id + " " + ders1.Name + " " + ders1.Kredisi);
        Console.WriteLine();

        var ders2 = new Ders()
        {
            Id = 2,
            Name = "Türkçe",
            Kredisi = 3
        };

        Console.WriteLine(ders2.Id + " " + ders2.Name + " " + ders2.Kredisi);
        Console.WriteLine();

        var ders3 = new Ders();
        ders3.Id = 3;
        ders3.Name = "Matematik";
        ders3.Kredisi = 4;

        Console.WriteLine(ders3.Id + " " + ders3.Name + " " + ders3.Kredisi);
        Console.WriteLine();
        Console.WriteLine("--------------------------");

        Console.WriteLine("Öğrenci tanımlama (Yapıcı metodlu, List<> tanımlı, override yapısı ile çıktı biçimlendirme, Liste çıktısını .ForEach ve LAMBDA ile verme)");
        // Tanımlama Yapıcı Metod ile
        Ogrenci ogr1 = new Ogrenci();
        ogr1.Numara = 10;
        ogr1.Adi = "Selvi";
        ogr1.Soyadi = "Danacı";
        ogr1.Cinsiyet = false;
        //Console.WriteLine($"{ogr.Numara} {ogr.Adi} {ogr.Soyadi} {ogr.Cinsiyet}");

        Console.WriteLine(ogr1);

        var ogr2 = new Ogrenci();
        ogr2.Numara = 20;
        ogr2.Adi = "Bilge";
        ogr2.Soyadi = "Kaya";
        ogr2.Cinsiyet = false;
        //Console.WriteLine(ogrenci.Numara + " " + ogrenci.Adi + " " + ogrenci.Soyadi + " " + ogrenci.Cinsiyet);

        Console.WriteLine(ogr2);

        var ogr3 = new Ogrenci();
        ogr3.Numara = 30;
        ogr3.Adi = "Şükrü";
        ogr3.Soyadi = "Kaya";
        ogr3.Cinsiyet = true;

        Console.WriteLine(ogr3);
        Console.WriteLine();
        //-------------------------------------
        Console.WriteLine("List<> ile devam");
        // Liste
        var ogrListesi = new List<Ogrenci>()
        {
            new Ogrenci(40, "Ahmet", "Polat", true),
            new Ogrenci(50, "Mehmet", "Güneş"),
            new Ogrenci(60, "Asya", "Karlı", false)
        };
        foreach (var ogrenci in ogrListesi)
        {
            Console.WriteLine(ogrenci);//biçimlendirme yapıcı metodda override ile ToString() metunda yapılmıştır.
        }

        Console.WriteLine();
        Console.WriteLine("LAMBDA ile liste çıktısı");
        ogrListesi.ForEach(o => Console.WriteLine(o));
        
    }
}

public struct Ogrenci
{
    public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet = true)
    {
        Numara = numara;
        Adi = adi;
        Soyadi = soyadi;
        Cinsiyet = cinsiyet;
    }

    public int Numara { get; set; }
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool Cinsiyet { get; set; }

    // Geçersiz kılma / Ezme / Override
    public override string ToString()
    {  
        return $"{Numara, -5} {Adi, -10} {Soyadi, -10} " + string.Format("{0, -8}", Cinsiyet == true ? "Erkek" : "Kadın");
    }
}

public struct Ders
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Kredisi { get; set; }
}

