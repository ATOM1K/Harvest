using Microsoft.VisualBasic;

internal class Program
{
    /*
     * В некотором году (назовем его условно первым)
     * на участке в 100 гектаров средняя урожайность ячменя
     * составила 20 центнеров с гектара.
     * После этого каждый год
     * площадь участка увеличивалась на 5%,
     * а средняя урожайность — на 2%.
     * Определить:
        а) урожайность за второй, третий, …, восьмой год;
        б) площадь участка в четвертый, пятый, …, седьмой год;
        в) какой урожай будет собран за первые шесть лет.
     */

    //(a,b / A,Б)
    public static void Productivity(float  hectarsInside, float centnersInside)
    {   
        Console.Write("Enter number of years: ");
        int years = int.Parse(Console.ReadLine());
        FirstYearHarvest(hectarsInside, centnersInside);
        for (int i = 2; i <= years; i++)
        {
            hectarsInside = hectarsInside * 1.05f;
            centnersInside = centnersInside * 1.02f;
            Console.WriteLine($"{i} year hectares: {Math.Round(hectarsInside, 2)};\t {i} year harvest: {Math.Round(centnersInside, 2)};");
        }

    }

    public static void SumHarvest(float centnersInside)
    {
        float counterHarvest = centnersInside;
        for (int i = 2; i <= 6; i++)
        {
            centnersInside = centnersInside * 1.02f;
            counterHarvest = counterHarvest + centnersInside;
        }
        Console.WriteLine($"Harvest for first 6 years: {Math.Round(counterHarvest, 2)};");
    }

    public static void FirstYearHarvest(float hectars, float centners)
    {
        Console.WriteLine($"1 year hectares: {Math.Round(hectars, 2)};\t 1 year harvest: {Math.Round(centners, 2)};");
    }

    private static void Main(string[] args)
    {
        Console.Write("Enter number of hectares: ");
        float hectars = float.Parse(Console.ReadLine());
        Console.Write("Enter number centners of harvest: ");
        float centners = float.Parse(Console.ReadLine());

        Productivity(hectars, centners);
        Console.WriteLine("----------------------------------------------------");
        SumHarvest(centners);
    }
}