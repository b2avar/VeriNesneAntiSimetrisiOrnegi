
using VeriNesneAntiSimetrisiOrnegi;

Geometri geometriObj = new Geometri();
double sonuc;

Kare kareObj = new Kare();
kareObj.SetKenar(4);

Dikdortgen dikdortgenObj = new Dikdortgen();
dikdortgenObj.SetYukseklik(9);
dikdortgenObj.SetGenislik(3);

Daire daireObj = new Daire();
daireObj.SetYaricap(2);

sonuc = geometriObj.AlanHesabı(kareObj);
Console.WriteLine("Karenin Alanı : " + sonuc );

sonuc = geometriObj.AlanHesabı(dikdortgenObj);
Console.WriteLine("Dikdortgenin Alanı : " + sonuc);

sonuc = geometriObj.AlanHesabı(daireObj);
Console.WriteLine("Dairenin Alanı : " + sonuc);



