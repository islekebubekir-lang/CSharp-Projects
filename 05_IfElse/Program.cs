/* Console.WriteLine("Bir sayi giriniz ");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi % 2 == 0)
{
    System.Console.WriteLine($"{sayi} cift bir sayidir ");

}
else
{
    System.Console.WriteLine($"{sayi} tek bir sayidir. ");

}
 */

/* int n = Convert.ToInt32(Console.ReadLine()!);
if (n < 0)
{
    System.Console.WriteLine($"|{n}| = {n * -1}");

}
else
{
    System.Console.WriteLine($"|{n}| = {n}");
} */

/* var k = (char)Console.Read();
if (char.IsDigit(k))
{
    System.Console.WriteLine($"{k} Bu Bir Rakamdir");

}
else if (char.IsLower(k))
{
    System.Console.WriteLine($"{k} Bu bir kücük Karakterdir.");

}
else if (char.IsUpper(k))
{
    System.Console.WriteLine($"{k} Bu bir Buyuk karakterdir.");

}
else
{
    System.Console.WriteLine($"{k} Bu bir bilinmeyen karakterdir");

} */

/* System.Console.WriteLine("Lütfen bir sayi giriniz ");
int sayi = Convert.ToInt32(Console.ReadLine()!);
if (sayi > 0)
{
    System.Console.WriteLine("Bu sayi pozitif bir sayidir.");

}
else if (sayi<0)
{
    System.Console.WriteLine("Bu sayi negatif bir sayidir.");
}
else 
{
    System.Console.WriteLine("Sayi sifirdir.");
} */

using System.Diagnostics.Tracing;
using System.Runtime.Intrinsics.Arm;

/* System.Console.WriteLine(@"Öğrenci misiniz? (evet/hayir)");
string cevap = Console.ReadLine()!;
if (cevap == "evet")
{
    System.Console.WriteLine("Gecisiniz Ucretsizdir");

}
else
{
    System.Console.WriteLine("Gecis Ücreti Ödeyiniz."); 

 } */
/* int hiz = Convert.ToInt32(Console.ReadLine()!);
if (hiz >= 0 && hiz <= 90)

{
    System.Console.WriteLine("Hiz Limiti Sinirlari icinde Olduğunuz için tesekkür ederiz.");
}
else if (hiz > 90)
{
    System.Console.WriteLine("Hiz limitini Astiniz!");
}
else if (hiz < 0)
{
    System.Console.WriteLine("Gecersiz Hiz Limiti.");
}
System.Console.WriteLine("Toplam tutar giriniz. "); */
/* double toplamTutar = Convert.ToDouble(Console.ReadLine()!);
if (toplamTutar <= 0)
{
    System.Console.WriteLine("Gecersiz tutar girdiniz.");

}
else if (toplamTutar > 0)
{
    System.Console.WriteLine("Vip kartiniz varmi? evet/hayir");
    string vipKart = Console.ReadLine()!;
    if (vipKart == "evet")
    {
        if (toplamTutar >= 500)
        {
            toplamTutar = toplamTutar * 0.80;
        }
        else
        {
            toplamTutar = toplamTutar * 0.90;
        }
    }
    else
    {
        if (toplamTutar >= 500)
        {
            toplamTutar = toplamTutar * 0.95;
        }
    }
    System.Console.WriteLine($"Ödemeniz gereken net tutar:{toplamTutar}TL");


} */
System.Console.WriteLine("Lütfen Yaşinizi giriniz?");
int yas =Convert.ToInt32 (Console.ReadLine()!);
if (yas<=0)
{
    System.Console.WriteLine("Gecersiz Yas Girdiniz.");

}else if(yas>0)
{
    System.Console.WriteLine("Korku mu Animasyon mu?");
    string filmTuru = Console.ReadLine()!;






if (filmTuru == "korku" && yas < 18)
{
    System.Console.WriteLine("Bu filme yasiniz yetmiyor, giris yapamazsiniz!");
}
else
{
    double biletFiyati = 200;

    if (yas < 12)
    {
        biletFiyati = biletFiyati * 0.50;
    }
    else if (yas >= 65)
    {
        biletFiyati = biletFiyati * 0.70;
    }
else
{
    System.Console.WriteLine($"Iyi seyirler! Bilet ucretiniz: {biletFiyati} TL");
}
}}
