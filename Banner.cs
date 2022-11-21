namespace Bannerlib;

public class Banner
{
    private float Width;
    private float Height;

    public Banner()
    {
        Width = 12.5f;
        Height = 25.2f;
    }
    public Banner(float Width, float Height)
    {
        this.Width = Width;
        this.Height = Height;
    }

    public float w
    {
        get {return Width;}
        set {Width = value;}
    }

    public float h
    {
        get{return Height;}
        set{Height = value;}
    }

    public virtual double area()
    {
        return Width * Height;
    }
}