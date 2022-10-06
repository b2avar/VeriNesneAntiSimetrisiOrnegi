
using VeriNesneAntiSimetrisiOrnegi;

double sonuc;

Kare kareObj = new Kare();
kareObj.SetKenar(4);

Dikdortgen dikdortgenObj = new Dikdortgen();
dikdortgenObj.SetYukseklik(9);
dikdortgenObj.SetGenislik(3);

Daire daireObj = new Daire();
daireObj.SetYaricap(2);

sonuc = kareObj.AlanHesabı();
Console.WriteLine("Karenin Alanı : " + sonuc );

sonuc = dikdortgenObj.AlanHesabı();
Console.WriteLine("Dikdortgenin Alanı : " + sonuc);

sonuc = daireObj.AlanHesabı();
Console.WriteLine("Dairenin Alanı : " + sonuc);



