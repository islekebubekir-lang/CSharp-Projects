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

/* int[] sayilar = { 45, 12, 89, 23, 67, 94, 5, 51 };
int enBüyükSayi = sayilar[0];

    for (int i = 0; i < sayilar.Length; i++)
    {if (sayilar[i]>enBüyükSayi)
     enBüyükSayi=sayilar[i];
    {
        
    }

}
System.Console.WriteLine($"En buyuk sayi: {enBüyükSayi}");
 */

using System.Dynamic;

/* int [,] matris={{2,5,7,8},{1,4,6,9}};
 for (int i = 0; i < matris.GetLength(0); i++)
 
 {for (int j = 0; j < matris.GetLength(1); j++)
 if (matris[i,j]%2==0)
 {
        System.Console.WriteLine($"Çift sayilar: {matris[i,j]}");

 }
 } */

/* int[,] sayilar = { { 1, 3, 5, 7 }, { 2, 4, 6, 8 } };
int toplam = 0;

for (int i = 0; i < sayilar.GetLength(0); i++)
{
    for (int j = 0; j < sayilar.GetLength(1); j++)
        toplam += sayilar[i, j];




}
System.Console.WriteLine($"Sayilarin toplami: {toplam}");
double ortalama = (double) toplam / sayilar.Length;
System.Console.WriteLine($"Sayilarin ortalamasi: {ortalama}"); */

/* int [,] matris = {{1,3,5,},{2,4,6,},{3,6,9}};
int enBuyukSayi = matris[0,0];
for (int i = 0; i < matris.GetLength(0); i++)
{
    for (int k = 0; k < matris.GetLength(1); k++)

    {
        if (enBuyukSayi<matris[i,k])
        {
           enBuyukSayi=matris[i,k];
        }

    }

}System.Console.WriteLine($"En büyük sayi: {enBuyukSayi}"); */

int[,] sayilar = { { 1, 2, 5, },{ 3, 4, 8 } };
int ciftSayiAdedi = 0;
for (int i = 0; i < sayilar.GetLength(0); i++)
    for (int m = 0; m < sayilar.GetLength(1); m++)


        if (sayilar[i, m] % 2 == 0)
            ciftSayiAdedi++;
{

}
{

}System.Console.WriteLine($"Matrisin içinde ki cift sayi adedi. {ciftSayiAdedi}");







