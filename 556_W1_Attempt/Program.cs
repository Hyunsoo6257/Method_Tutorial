namespace _556_W1_Attempt;

class Program
{
    public static void Main(string[] args)
    {
        // Prompt the users for length and width of a room feet
        // Create a method that accepth the values
        // and then compute the cost of painiting the room

        const int Height = 9;

        Console.WriteLine("Enter the length of a room: ");
        int Length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the width of a room: ");
        int Width = Convert.ToInt32(Console.ReadLine());

        PaintingEstimate(Length, Width, Height);

    }
  
    static string PaintingEstimate(int Length, int Width, int Height) {
        int Square = 2 * (Length * Width + Length * Height + Width * Height);
        string CostOfPainting = (6 * Square).ToString("C");

        Console.WriteLine(CostOfPainting);
        Console.ReadLine();
        return CostOfPainting;
    }

    
}

