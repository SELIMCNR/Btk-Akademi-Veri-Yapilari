internal class Program
{
    private static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        Console.WriteLine("{0},{1}",x,y);
        
        Degistir(ref x,ref y);
        
        Console.WriteLine("{0},{1}",x,y);

        Console.ReadKey();
    }

    private static void Degistir(ref int x,ref int y)
    {
        int gecici = x;
        x = y;
        y=gecici;
        Console.WriteLine("{0},{1}", x, y);
    }
}