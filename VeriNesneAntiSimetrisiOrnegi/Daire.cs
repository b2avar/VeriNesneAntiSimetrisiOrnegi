namespace VeriNesneAntiSimetrisiOrnegi;

public class Daire:Sekil
{
    private double yaricap;
    private double pi = 3.14;
    public double GetYaricap()
    {
        return yaricap;
    }

    public void SetYaricap(double yaricap)
    {
        this.yaricap = yaricap;
    }

    public override double AlanHesabı()
    {
        return pi * (yaricap * yaricap);
    }
}