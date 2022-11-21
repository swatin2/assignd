namespace Hospitallib;

public class Patient
{
    private double PatientId;
    private int BedType;
    private int NoOfDays;

    public Patient(double Pid, int Bt, int Nod)
    {
        PatientId = Pid;
        BedType = Bt;
        NoOfDays = Nod;
    }

    public Patient() : this(0,0,0)
    {
    }

    public double Pid
    {
        get
        {
            return PatientId;
        }

        set
        {
            PatientId = value;
        }
    }

    public int Bt
    {
        get 
        {
            return BedType;
        }

        set
        {
            BedType = value;
        }
    }

    public int Nod
    {
        get
        {
            return NoOfDays;
        }

        set
        {
            NoOfDays = value;
        }
    }

    public virtual double GetBillAmount()
    {
        int price = 0;

        if(BedType == 1)
            price  = 500;
        if(BedType == 2)
            price  = 350;
        if(BedType == 3)
            price  = 200;
        else
            price = 150;

        double amount = price * NoOfDays;
        return amount;

    }

    

}