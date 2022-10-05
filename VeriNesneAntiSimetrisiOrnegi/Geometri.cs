namespace VeriNesneAntiSimetrisiOrnegi;

public class Geometri
{
    private double pi = 3.14f;

    public double AlanHesabı(Object sekil)
    {
        if (sekil.GetType().Name == "Kare")
        {
            Kare kareObj = (Kare)sekil;
            return kareObj.GetKenar() * kareObj.GetKenar();
        }
        
        else if (sekil.GetType().Name == "Dikdortgen")
        {
            Dikdortgen dikdortgenObj = (Dikdortgen)sekil;
            return dikdortgenObj.GetYukseklik() * dikdortgenObj.GetGenislik();
        }
        
        else if (sekil.GetType().Name == "Daire")
        {
            Daire daireObj = (Daire)sekil;
            return pi * daireObj.GetYaricap() * daireObj.GetYaricap();
        }

        else
        {
            return 0;
        }
    }
}