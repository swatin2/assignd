using Bannerlib;

class Program
{
    static double BannerPrice(Banner info, int Copies)
    {
        float rate = Copies > 5 ? 0.20f : 0.30f;
        return rate * Copies * info.area(); 
    }

    public static void Main(string[] args)
    {
        float w = float.Parse(args[0]);
        float h = float.Parse(args[1]);
        float r = float.Parse(args[2]);

        Banner b = new Banner(w, h);
        Console.WriteLine("size of regular banner = {0:0.00} sqcm",b.area());
        Console.WriteLine("price of regular banner = {0:0.00}",BannerPrice(b, 10));

        Console.WriteLine("---------------------------------------------------------");
        
        CurvedBanner cb = new CurvedBanner(w, h, r);
        Console.WriteLine("size of curvedbanner = {0:0.00} sqcm",cb.area());
        Console.WriteLine("price of curvedbanner = {0:0.00}",BannerPrice(cb, 4));


    }
}
