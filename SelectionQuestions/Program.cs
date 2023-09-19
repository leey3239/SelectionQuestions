class TestClass
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
    static void Main(string[] args)
    {
        
        FizzBuzz(15);
    }
}

