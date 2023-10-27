using Calisma;
using System.Diagnostics;
LPG LPG = new LPG();
Dizel DİZEL = new Dizel();
Elektrik ELEKTRİK = new Elektrik();
Musteri musteri = new Musteri();
Benzin BENZİN = new Benzin();
Dictionary<string,Yakit> Musteriler = new Dictionary<string,Yakit>();

musteri.YakitAlindi += YakitAliniyor;
Console.WriteLine("Plaka No Giriniz:");
string? PlakaNo = Console.ReadLine();
if (PlakaNo != null)
musteri.PlakaNo = PlakaNo;


if (Musteriler.ContainsKey(musteri.PlakaNo))
{
    Console.WriteLine("Tanımlı Müşteri. Yakıt Türü : " + Musteriler[PlakaNo]);
    musteri.YakıtTur = Musteriler[PlakaNo];
}

else
{
    Console.WriteLine("Yakıt Tipini Seçiniz:\n1. LPG\n2. BENZİN\n3. DİZEL\n4. ELEKTRİK");
    int secilen = Convert.ToInt32(Console.ReadLine());
    switch (secilen)
    {
        case 1:
            musteri.YakıtTur = LPG; break;    
        case 2:
            musteri.YakıtTur = BENZİN; break;
        case 3:
            musteri.YakıtTur = DİZEL; break;
        case 4:
            musteri.YakıtTur = ELEKTRİK; break;  
        default:
            Console.WriteLine("LÜTFEN GEÇERLİ BİR GİRİŞ YAPINIZ."); break;

    }

    Musteriler.Add(PlakaNo, musteri.YakıtTur);
    Console.WriteLine("müşteri Tanımlandı. Plaka: " + PlakaNo + "  Yakıt Tipi: " + musteri.YakıtTur);
}

musteri.istenilenMiktar = 50;
musteri.YakıtAl();

void YakitAliniyor()
{
    Console.WriteLine(" kalan benzin miktarı: " + (BENZİN.Miktar - musteri.istenilenMiktar));
    Console.WriteLine("Ödenecek Tutar: "+ (musteri.istenilenMiktar*BENZİN.Fiyat));

}


