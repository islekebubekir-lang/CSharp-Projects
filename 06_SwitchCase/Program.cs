/* double bakiye = 1000;
System.Console.WriteLine("1:Bakiye Sorgulama / 2:Para Cekme / 3:Para Yatirma");
int sayi = Convert.ToInt32(Console.ReadLine()!);

switch (sayi)
{
    case 1:
        System.Console.WriteLine($"Bakiyeniz: {bakiye} TL");
        break;

    case 2:

        System.Console.WriteLine("Cekmek istediginiz tutari giriniz:");
        double cekilecekTutar = Convert.ToDouble(Console.ReadLine()!);
        bakiye -= cekilecekTutar;
        System.Console.WriteLine($"Kalan Bakiyeniz: {bakiye} TL");

        break;

    case 3:
        System.Console.WriteLine("Yatirmak istediginiz tutari giriniz:");
        double yatirilacakTutar = Convert.ToDouble(Console.ReadLine()!);
        bakiye += yatirilacakTutar; // bakiye = bakiye + yatirilacakTutar
        System.Console.WriteLine($"Yeni Bakiyeniz: {bakiye} TL");
        break;

    default:
        System.Console.WriteLine("Gecersiz Islem Girdiniz.");
        break;
} 
 */
System.Console.WriteLine("1/Aksiyon Filmi:120 TL. 2/Komedi Filmi:80 TL. 3/Animasyon Filmi:60 TL. ");
int secim = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine("Bakiye Giriniz. ");
double bakiye = Convert.ToDouble(Console.ReadLine()!);

switch (secim)
{
    case 1:
        if(bakiye >= 120)
         bakiye -= 120;
        System.Console.WriteLine($"Biletiniz Alindi! Kalan bakiyeniz {bakiye}TL.");

        break;
    case 2:
        if(bakiye >= 80)
bakiye -= 60;
        System.Console.WriteLine($"Biletiniz Alindi! Kalan bakiyeniz{bakiye}TL.");
        break;
        case 3:
        if(bakiye >= 60)
        bakiye -= 60;
        System.Console.WriteLine($"Biletiniz Alindi! Kalan Bakiye{bakiye}TL.");
        break;
    default:
        break;
}