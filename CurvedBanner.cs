namespace Bannerlib;

public class CurvedBanner : Banner
{
    public float Radius { get; set; }

    public CurvedBanner(float W, float H, float Radius) : base(W,H)
    {
        this.Radius = Radius;
    }

    public override double area()
    {
        double area = base.area();
        return area - 0.70 * Radius * Radius;
    }
}