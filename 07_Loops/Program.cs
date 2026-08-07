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

/* int toplam = 0;
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
System.Console.WriteLine("Girdiginiz pozitif sayilarin toplami" + toplam); */
/* 
for (int i = 0; i <= 100; i += 1)
{
    if (i % 3 == 0)
    {
        continue;
    }
    System.Console.WriteLine(i);



}
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        System.Console.WriteLine(i);

    }
}
for (int i = 1; i <= 50; i++)
{
    if (i % 3 == 0 && i % 5 != 0)
    {
        System.Console.WriteLine(i);
    }

}
int sayac=0;
for (int i = 1; i <= 100; i++)
    if (i % 2 == 0 && i % 3 == 0)
        sayac++;
{
    
}
System.Console.WriteLine("Hem İkiye Hem Üçe Bölünen sayi adedi: "+ sayac); */
/* int baslangic = 100;
int son = 1;
while (baslangic >= son)
{
    if (baslangic % 7 == 0)
    {
        System.Console.WriteLine(baslangic);
    }
    baslangic--;
} */

/* int ilk=1;
int son=50;
while (ilk<=son)
{if (ilk%4==0 && ilk%6==0)
{
    System.Console.WriteLine(ilk);
}
 ilk++;
} */

/* System.Console.WriteLine("Lütfen bir sayi giriniz. ");
int sayi=Convert.ToInt32(Console.ReadLine()!);
do
{
    System.Console.WriteLine(sayi);
    sayi--;
} while (sayi>0); */

/* int toplam = 0;
int sayi;

do
{
    System.Console.WriteLine("Lütfen bir sayi giriniz");
    sayi = Convert.ToInt32(Console.ReadLine()!);
    toplam +=sayi ;

} while (sayi != 0);
System.Console.WriteLine("toplam"+toplam); */

/* int sayi = 100;

while (sayi > 0)
{
    if (sayi % 5 == 0)
    {
        System.Console.WriteLine(sayi);

    }
    sayi--;
} */

/* int toplam = 0;
int girilen;
do
{
    System.Console.WriteLine("Lütfen bir sayi giriniz.");
    girilen = Convert.ToInt32(Console.ReadLine());
    toplam += girilen;
} while (girilen >= 0);
System.Console.WriteLine("Girilen sayi toplami." + toplam); */

int sinir;
System.Console.WriteLine("Lütfen bir sayi giriniz.");
sinir = Convert.ToInt32(Console.ReadLine()!);
for (int i = 1; i <= sinir; i++)
{
    if (i % 2 != 0)
    {
        System.Console.WriteLine(i);
    }

}



