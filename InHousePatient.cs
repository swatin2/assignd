namespace Hospitallib;

public class InHousePatient : Patient
{
    private float Discount;
    public InHousePatient(double pid, int bt, int nod, float d) : base(pid, bt, nod)
    {
        Discount = d;
    }

    public float Disc
    {
        get
        {
            return Discount;
        }
    }

    public override double GetBillAmount()
    {
        double amount = base.GetBillAmount();

        if(amount > 5000)
            amount -= amount * 0.05; //amount = amount - (amount * 0.05)
        return amount;
    }
}