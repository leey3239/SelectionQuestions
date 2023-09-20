class Solution
{

    static string FizzBuzz(int num)
    {
        bool fizz = false;
        bool buzz = false;
        if (num % 3 == 0)
        {
            fizz = true;
        }
        if (num % 5 == 0)
        {
            buzz = true;
        }
        if (fizz && buzz)
        {

            return "FizzBuzz";

        }
        else if (fizz)
        {

            return "Fizz";

        }
        else if (buzz)
        {

            return "Buzz";

        }
        else
        {
            return num.ToString();
        }

    }
    static bool VowelOrConsonant(char letter)
    {
        switch (letter)
        {
            case 'a':
                return true;
            case 'e':
                return true;
            case 'i':
                return true;
            case 'o':
                return true;
            case 'u':
                return true;
            default:
                return false;
        }
    }
    static void DiceRoller()
    {
        Random rnd = new Random();

        int d1 = rnd.Next(1, 7);
        int d2 = rnd.Next(1, 7);
        int d3 = rnd.Next(1, 7);
        if (d1 == d2 && d2 == d3)
        {
            Console.WriteLine("Three of a kind");
        }
        else if (d1 == d3 || d2 == d3 || d1 == d2)
        {
            Console.WriteLine("You have a pair");
        }
        else
        {
            Console.WriteLine("Sorry you lose");
        }
    }
    enum AngleTypes
    {
        Acute,
        Right_Angle,
        Obtuse,
        Straight,
        Reflex,
        Invalid
    }
    static Solution.AngleTypes AngleCheck(double angle)
    {
        if (angle < 90)
        {

            return AngleTypes.Acute;

        }
        else if (angle == 90)
        {
            return AngleTypes.Right_Angle;
        }
        else if (angle > 90)
        {
            return AngleTypes.Obtuse;
        }
        else if (angle == 180)
        {
            return AngleTypes.Straight;
        }
        else if (angle > 180)
        {
            return AngleTypes.Reflex;
        }
        else
        {
            return AngleTypes.Invalid;
        }
    }
    static void RoPaSi(int choice)
    {
        Random rnd = new Random();
        int comChoice = rnd.Next(1, 4);
        if ((comChoice == 1 && choice == 1) || (comChoice == 2 && choice == 2) || (comChoice == 3 && choice == 3)) {
            Console.WriteLine("Draw");
        } else if ((comChoice == 1 && choice == 2) || (comChoice == 2 && choice == 3) || (comChoice == 3 && choice == 1)) {
            Console.WriteLine("You lose");
        } else {
            Console.WriteLine("You win");
        }


    }
    static string TriangleCheck(double s1, double s2, double s3)
    {
        if (s1 == s2 && s2 == s3) {
            return "Equilateral";
        } else if (s1 == s2 || s2 == s3 || s3 == s1) {
            return "Isoceles";
        } else {
            return "Scalene";
        }
    }
    static void ConcertSale() {
        Console.WriteLine("Price of tickets: ");
        string ticketPrice = Console.ReadLine();
        double ticketPrice2;
        double.TryParse(ticketPrice, out ticketPrice2);

        Console.WriteLine("Number of tickets sold: ");
        string ticketsSold = Console.ReadLine();
        int ticketsSold2;
        int.TryParse(ticketsSold, out ticketsSold2);
        if (ticketPrice2 == 0 || ticketsSold2 == 0)
        {
            Console.WriteLine("Invalid input.");
        } else
        {
            Console.WriteLine($"The price is £ {ticketsSold2 * ticketPrice2}.");
        }

    }
    static bool HolidayCheck(DateTime birthTime) {
        DateTime now = DateTime.Now;
        DateTime if18 = birthTime.AddDays(6575);
        DateTime if30 = birthTime.AddDays(10958);

        Console.WriteLine($"If you were 18+, today would be over {if18}.");
        Console.WriteLine($"If you were 30+, today would be over {if30}.");
        return (now > if18 && now < if30);
    }
    static DateTime GetBirthday()
    {
        Console.WriteLine("Day: ");
        
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Month: ");
        
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Year: ");
        
        int year = Convert.ToInt32(Console.ReadLine());

        DateTime myDate = new DateTime(year, month, day, 00, 00, 00, 000);
        return myDate;
    }

    // Main Method
    static public void Main(String[] args)
    {

        Console.WriteLine(FizzBuzz(15));
        Console.WriteLine(VowelOrConsonant('e'));
        DiceRoller();
        Console.WriteLine(AngleCheck(123));
        Console.WriteLine("1 for Rock, 2 for Scissors, 3 for Paper");
        int RoPaSiInput = int.Parse(Console.ReadLine());
        if ( RoPaSiInput >= 1 && RoPaSiInput <= 3) {
            RoPaSi(RoPaSiInput);
        }
        
        Console.WriteLine(TriangleCheck(3.5, 3.5, 4));
        ConcertSale();
        Console.WriteLine(HolidayCheck(GetBirthday()));

    }



}