/* int a = 0;
while (a<10)
{
    System.Console.WriteLine(a);
    a++;
} */

/* bool hatMesgulMu=true;
while (hatMesgulMu)
{
    System.Console.WriteLine("Aradiğiniz Kişi Başka Birisiyle Görüşmektedir. ");
    hatMesgulMu=false;
} */

/* bool adminMi = true;
while (adminMi)
{
    System.Console.WriteLine("Hosgeldiniz. ");
    adminMi = false;
}
System.Console.WriteLine("Bir sayi giriniz.");
int n = Convert.ToInt32(Console.ReadLine()!);
int i = 2;
do
{
    System.Console.WriteLine("{0,3}", i);
    i += 1;
} while (i <= n); */
/* 
int gizliSayi = 42;
System.Console.WriteLine("Bir sayi giriniz. ");
int n = Convert.ToInt32(Console.ReadLine()!);

do
{
    if (n > gizliSayi)
    {
        System.Console.WriteLine("Daha küçük bir sayi giriniz");
        n = Convert.ToInt32(Console.ReadLine()!);
    }
    else if (n < gizliSayi)
    {
        System.Console.WriteLine("Daha büyük bir sayi giriniz.");
        n = Convert.ToInt32(Console.ReadLine()!);
    }
    else if (n == gizliSayi)
    {
        System.Console.WriteLine("Tebrikler Doğru sayiyi girdiniz.");
    }
} while (gizliSayi != n); */

int toplam = 0;
int sayi;
do
{
    System.Console.WriteLine("Lütfen bir sayi giriniz.");
    sayi = Convert.ToInt32(Console.ReadLine()!);

    if (sayi > 0)
    {
        toplam += sayi;

    }
    else
    {

    }
} while (sayi > 0);
System.Console.WriteLine("Girdiginiz pozitif sayilarin toplami" + toplam);


