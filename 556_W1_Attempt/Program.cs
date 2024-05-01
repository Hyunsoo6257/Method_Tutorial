namespace _556_W1_Attempt;

class Program
{
    static void Main(string[] args)
    {
        // prompt users for a number of miles
        // pass the value and converts the value to kilometers
        // A mile is 1.60934 kilometers
        const double ONE_MILE = 1.60934;

        Console.WriteLine("Enter the number of miles:");
        double miles =Convert.ToDouble(Console.ReadLine());
        double kilometers;
        kilometers= ConvertMilesToKilometers(miles, ONE_MILE);
        Console.WriteLine("The kilometer is {0}", kilometers);


    }

    private static double ConvertMilesToKilometers(double miles, double ONE_MILE) {
        double kilometers = ONE_MILE * miles;
        return kilometers;
    }



}

