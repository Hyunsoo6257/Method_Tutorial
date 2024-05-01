namespace _556_W1_Attempt;

class Program
{
    static void Main(string[] args)
    {
        // prompt users enter a numeric high school grade point average
        // promt users enter an admission test score
        // pass the value and converts the value to kilometers
        // A mile is 1.60934 kilometers
        double gpa;
        int testScore;
        const double MINGPA = 3.0;
        const int ADMIN1 = 60, ADMIN2 = 80;

        Console.WriteLine("Enter grade point average:");
        gpa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter grade point average:");
        testScore = Convert.ToInt32(Console.ReadLine());

        string CheckAdmission = AdmissionModularized(gpa, testScore, MINGPA, ADMIN1, ADMIN2);
        Console.WriteLine("The Admission is {0}", CheckAdmission);


    }

    private static string AdmissionModularized(double gpa, int testScore, double MINGPA, int ADMIN1, int ADMIN2) {

        if (gpa >= MINGPA)
        {
            if (testScore >= ADMIN1)
            {
                return "Accept";

            }
            else
            {
                return "Reject";
            }
        }
        else
            if (testScore >= ADMIN2)
            return "Accept";
        else
            return "Reject";
    } 



}

