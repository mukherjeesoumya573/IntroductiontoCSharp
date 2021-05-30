using System;

class Program
{

    public static void Main()
    {
        string UserDecision = String.Empty;
        do
        {
            int Result = 0;
            Console.WriteLine("Welcome to a basic Calculator");
            Console.WriteLine("enter 1 - Addition , 2 - Subtraction , 3 - Multiplication");
            int UserChoice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the first integer");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second integer");
            int y = int.Parse(Console.ReadLine());

            if (UserChoice == 1)
            {
                Console.WriteLine("Your Result is {0}", Add(x, y));

            }
            if (UserChoice == 2)
            {
                Console.WriteLine("Your Result is {0}", Subtract(x, y));

            }
            if (UserChoice == 3)
            {
                Console.WriteLine("Your Result is {0}", Subtract(x, y));

            }
            do
            {

                Console.WriteLine("Do you want to Continue? Yes or No");

                if (UserDecision != "YES" && UserDecision != "NO")
                {
                    UserDecision = Console.ReadLine().ToUpper();
                    Console.WriteLine("Please say Yes or No");
                }
            } while (UserDecision != "YES" && UserDecision != "NO");
        } while (UserDecision == "YES");

    }


    public static int Add(int x, int y)
    {
        return x + y;
    }
    public static int Subtract(int x, int y)
    {
        return x - y;
    }
    public static int Multiply(int x, int y)
    {
        return x * y;
    }

}