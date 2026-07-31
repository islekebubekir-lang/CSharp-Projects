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
int hiz = Convert.ToInt32(Console.ReadLine()!);
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