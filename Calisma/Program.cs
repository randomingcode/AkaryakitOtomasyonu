using Calisma;
using System.Diagnostics;


LPG LPG = new LPG();
Dizel DİZEL = new Dizel();
Elektrik ELEKTRİK = new Elektrik();

Benzin BENZİN = new Benzin();
Dictionary<string, Yakit> Musteriler = new Dictionary<string, Yakit>();
Musteri musteri = new Musteri();
musteri.YakitAlindi += YakitAliniyor;

while(true)
{
    Console.WriteLine("Plaka No Giriniz:");

    PlakaKontrol();


    if (Musteriler.ContainsKey(musteri.PlakaNo))
    {
        Console.WriteLine("Tanımlı Müşteri. Yakıt Türü : " + Musteriler[musteri.PlakaNo]);
        musteri.YakıtTur = Musteriler[musteri.PlakaNo];
    }
    else YakitTipiAl();

    Console.WriteLine("müşteri Tanımlandı. Plaka: " + musteri.PlakaNo + "  Yakıt Tipi: " + musteri.YakıtTur);

    while (true)
    {
        Console.WriteLine("Miktar giriniz:");
        string istenilenMiktar = Console.ReadLine();

        if (double.TryParse(istenilenMiktar, out double istenilenM))
        {
            musteri.istenilenMiktar = istenilenM;
            musteri.YakıtAl();
            break;

        }
        else { Console.WriteLine("geçerli bir miktar giriniz."); return; };


    }
}
    void YakitAliniyor()
    {
        musteri.YakıtTur.YakitAl(musteri);
    }
    void YakitTipiAl()
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
                Console.WriteLine("LÜTFEN GEÇERLİ BİR GİRİŞ YAPINIZ.");
                YakitTipiAl();
                break;

        }
        Musteriler.Add(musteri.PlakaNo, musteri.YakıtTur);
    }
    void PlakaKontrol()
    {
        string? girilenPlaka = Console.ReadLine();
        if (girilenPlaka.Length == 7 || girilenPlaka.Length == 8)
        {
            if (int.TryParse(girilenPlaka.Substring(0, 2), out int num))
            {
                if (num > 0 && num < 82)
                {
                    if (girilenPlaka.Length == 7)
                    {
                        if (girilenPlaka.Substring(2, 4).Any(c => char.IsLetter(c)))
                        {
                            if (girilenPlaka.Substring(5, 8).Any(c => char.IsDigit(c)))
                            {
                                musteri.PlakaNo = girilenPlaka;

                            }
                            else { Console.WriteLine("Hatalı Plaka Kodu!"); PlakaKontrol(); }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Plaka Kodu!"); PlakaKontrol();
                        }
                    }
                    else if (girilenPlaka.Length == 8)
                    {

                        if (girilenPlaka.Substring(2, 5).Any(c => char.IsLetter(c)))
                        {
                            if (girilenPlaka.Substring(5).Any(c => char.IsDigit(c)))
                            {
                                Console.WriteLine("Plaka Kodu Doğrulandı. "); musteri.PlakaNo = girilenPlaka;
                            }
                            else { Console.WriteLine("Hatalı Plaka Kodu!"); PlakaKontrol(); }
                        }
                        else { Console.WriteLine("Hatalı Plaka Kodu!"); PlakaKontrol(); }
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı İl Kodu!"); PlakaKontrol();
                }
            }
            else
            {
                Console.WriteLine("Hatalı İl Kodu!"); PlakaKontrol();
            }
        }
        else { Console.WriteLine("Geçersiz Plaka Kodu!"); PlakaKontrol(); }

    }



