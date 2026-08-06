/* int[] numaralar; numaralar = new int[3] { 3, 5, 7 };
for (int i = 0; i < numaralar.Length; i++)
{
    System.Console.WriteLine($"Numaralar[{i}] = {numaralar[i]}");
}

int sayac = 0;
int[] sayilar = { 12, 55, 8, 90, 43, 67, 2, 100 };
for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] > 50)

    {
        System.Console.WriteLine(sayilar[i]);
        sayac++;

    }

}
System.Console.WriteLine("50'nin üzerinde ki sayilarin adedi. " + sayac); */

/* int adedi = 0;
int[] sayilar = { 15, 24, 7, 88, 33, 40, 11, 62 };
for (int i = 0; i < sayilar.Length; i++)
{
    if (sayilar[i] % 2 == 0)
    {
        System.Console.WriteLine(sayilar[i]);
        adedi++;
    }
}
    System.Console.WriteLine("İkiye bölünen sayilarin adedi " + adedi); */

int[] sayilar = { 45, 12, 89, 23, 67, 94, 5, 51 };
int enBüyükSayi = sayilar[0];

    for (int i = 0; i < sayilar.Length; i++)
    {if (sayilar[i]>enBüyükSayi)
     enBüyükSayi=sayilar[i];
    {
        
    }

}
System.Console.WriteLine($"En buyuk sayi: {enBüyükSayi}");






