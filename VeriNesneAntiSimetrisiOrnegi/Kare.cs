namespace VeriNesneAntiSimetrisiOrnegi;

public class Kare:Sekil
{
    private double kenar;
    public double GetKenar()
    {
        return kenar;
    }

    public void SetKenar(double kenar)
    {
        this.kenar = kenar;
    }

    public override double AlanHesabı()
    {
        return kenar * kenar;
    }
}