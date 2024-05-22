namespace OOP_Parameters_week2;

class Program
{
    static void Main(string[] args)
    {
        // Create program Reverse3 which declares three integers
        int firstInt =1;
        int middleInt =2;
        int lastInt =3;
        Console.WriteLine("firstInt: {0}, middleInt: {1}, lastInt: {2}", firstInt, middleInt, lastInt);
        Reverse3(ref firstInt, ref middleInt, ref lastInt);
        Console.WriteLine("firstInt: {0}, middleInt: {1}, lastInt: {2}", firstInt, middleInt, lastInt);
    }

    static void Reverse3(ref int firstInt, ref int middleInt, ref int lastInt){
        int temp;
        temp = firstInt;
        firstInt = lastInt;
        lastInt = temp;

        
    }
}

