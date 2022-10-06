namespace VeriNesneAntiSimetrisiOrnegi;

public class Dikdortgen:Sekil
{
    private double yukseklik;
    private double genişlik;
    public double GetYukseklik()
    {
        return yukseklik;
    }

    public void SetYukseklik(double yukseklik)
    {
        this.yukseklik = yukseklik;
    }

    public double GetGenislik()
    {
        return genişlik;
    }

    public void SetGenislik(double genislik)
    {
        this.genişlik = genislik;
    }

    public override double AlanHesabı()
    {
        return yukseklik * genişlik;
    }
}