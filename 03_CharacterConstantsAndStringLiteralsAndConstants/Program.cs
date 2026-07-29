string üyeAdi = "\nSoner\nErdem";
string üyeDogumYeri = "\tKonya\tMeram";
string üyeDogumTarihi = "02\\05\\1998";
bool medeniDurumu = false;
string anneAdi = @"Halime Erdem";
string babaAdi = "Ali \"Kemal\" Erdem";
System.Console.WriteLine($"{üyeAdi}{üyeDogumYeri} {üyeDogumTarihi} {medeniDurumu} {anneAdi} {babaAdi}");

string? giris = Console.ReadLine();
System.Console.WriteLine(giris);

var input = Console.ReadKey();
System.Console.WriteLine(input.Key);
System.Console.WriteLine(input.KeyChar);

string arabaMarkasi = " maserati ";
System.Console.WriteLine(arabaMarkasi);
System.Console.WriteLine(arabaMarkasi.Length);
System.Console.WriteLine(arabaMarkasi.ToUpper());
System.Console.WriteLine(arabaMarkasi.ToLower());
System.Console.WriteLine(arabaMarkasi.TrimStart());
System.Console.WriteLine(arabaMarkasi.TrimEnd());
System.Console.WriteLine(arabaMarkasi[0]);
System.Console.WriteLine(arabaMarkasi[1]);
System.Console.WriteLine(arabaMarkasi[arabaMarkasi.Length - 1]);





