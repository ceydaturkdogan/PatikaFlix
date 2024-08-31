

using PatikaFlix;
using System.IO;

List<Series> series = new List<Series>()
{

     new Series{Name="Avrupa Yakası",ProductionYear= 2004,Genre= "Komedi",StartYear= 2004,Directors= "Yüksel Aksu",FirstPlatform= "Kanal D" },
     new Series{Name="Yalan Dünya",ProductionYear= 2012, Genre= "Komedi", StartYear=2012, Directors="Gülseren Buda Başkaya",FirstPlatform= "Fox TV" },
     new Series{Name="Jet Sosyete",ProductionYear= 2018,Genre=  "Komedi",StartYear= 2018,Directors= "Gülseren Buda Başkaya",FirstPlatform= "TV8" },
     new Series{Name="Dadı",ProductionYear= 2006,Genre=  "Komedi",StartYear= 2006,Directors= "Yusuf Pirhasan", FirstPlatform="Kanal D" },
     new Series{Name="Belalı Baldız",ProductionYear= 2007,Genre=  "Komedi",StartYear= 2007,Directors= "Yüksel Aksu", FirstPlatform="Kanal D" },
     new Series{Name="Arka Sokaklar",ProductionYear= 2004,Genre=  "Polisiye, Dram", StartYear=2004, Directors="Orhan Oğuz", FirstPlatform="Kanal D" },
     new Series{Name="Aşk-ı Memnu",ProductionYear= 2008,Genre=  "Dram, Romantik",StartYear= 2008, Directors="Hilal Saral", FirstPlatform="Kanal D" },
     new Series{Name="Muhteşem Yüzyıl",ProductionYear= 2011,Genre=  "Tarihi, Dram",StartYear= 2011, Directors="Mercan Çilingiroğlu",FirstPlatform= "Star TV" },
     new Series{Name="Yaprak Dökümü", ProductionYear=2006, Genre= "Dram", StartYear=2006, Directors="Serdar Akar",FirstPlatform= "Kanal D" }
};

//İlk listenizde bulunan komedi dizilerinden yeni bir liste oluşturunuz. Bu listede yalnızca Dizi Adı / Dizi Türü / Yönetmen bilgileri yer alsın (Yani başka bir class ihtiyacınız doğuyor.)
// Bu yeni listenin bütün elemanlarını bütün özellikleriyle ekrana yazdırınız. Yazımın öncelikle dizi isimleri sonra da yönetmen isimleri baz alınarak sıralanmasına özen gösteriniz.

List<Comedy> comedy = series.Where(s => s.Genre.Contains("Komedi"))
                            .Select(s => new Comedy
                            {
                                Name= s.Name,
                                Directors= s.Directors,
                                Genre= s.Genre,
                            })
                            .OrderBy(s => s.Name)
                            .ThenBy(s => s.Directors)
                            .ToList();

foreach (var item in comedy)
{
    Console.WriteLine($"Series Name: {item.Name}, Genre: {item.Genre}, Directors: {item.Directors}");
}

