using System;
/*namespace _22_7_Assignment_13
{
  //Task 1: Hello World

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");
                Console.ReadKey();
            }

        }
}*/



//  Task 2: Variables and User Input

/*namespace _22_7_Assignment_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hello, {name}!");
            Console.ReadKey();
        }
          
    }
}*/


// Task 3: Basic Arithmetic



/*namespace _22_7_Assignment_13
{
        class Program
        {
            static void Main(string[] args)
            {
              Console.WriteLine("Enter First Number");
              int a = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter Second Number");
              int b = int.Parse(Console.ReadLine());
              int sum = a + b;
              int subtraction = a - b;
              int multiply = a * b;
              double division = a / b;
              double mdivision = a % b;
              Console.WriteLine($" sum is: { sum}" );
              Console.WriteLine($"subtraction is : {subtraction}");
              Console.WriteLine($"multiplication is : {multiply}");
              Console.WriteLine($"division is : {division}");
              Console.WriteLine($"mdivision : {mdivision} ");
              Console.ReadKey();
             }
        }
  }*/


// Task 4: Control Structures



/*namespace _22_7_Assignment_13
{
        class Program
        {
            static void Main(string[] args)
            {
              Console.WriteLine("Enter a Num to Know whether it is even or odd");
              int a = int.Parse(Console.ReadLine());
              if (a % 2 == 0)
              {
                  Console.WriteLine("Its even");
              }
              else
              {
                  Console.WriteLine("Its odd");
              }
              Console.ReadKey();
            }
        }
    }*/


// Task 5: Loops



/*namespace _22_7_Assignment_13
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
               Console.ReadKey();
           
        }
    }
} */



//  Task 6: Arrays



/*namespace _22_7_Assignment_13
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] list = { 10, 25, 20, 30, 50 };
            int sum = 0;
            foreach (int i in list)
            {
                sum += i;
            }
            int avg = sum/ list.Length;
            Console.WriteLine($" sum is {sum}");
            Console.WriteLine($" avg is {avg}");
            Console.ReadKey();

        }

    }
} */


           




           


//  Task 7: Methods



/*namespace _22_7_Assignment_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer to calculate its factorial:");
            int number = Convert.ToInt32(Console.ReadLine());

            long factorial = CalculateFactorial(number);

            Console.WriteLine($"Factorial of {number} is {factorial}");
        }

        static long CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;

            return n * CalculateFactorial(n - 1);

            Console.ReadKey();

        }
        

    }
} */





//  Task 8: Exception Handling

/*namespace _22_7_Assignment_13
    {
        class Program
        {
            static void Main(string[] args)
            {
                int age = 0;
                bool isValidInput = false;

                while (!isValidInput)
                {
                    Console.Write("Please enter your age: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out age))
                    {
                        if (age >= 0)
                        {
                            isValidInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Age cannot be negative.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid age (an integer).");
                    }
                }

                if (age < 18)
                {
                    Console.WriteLine("You are a minor.");
                }
                else if (age >= 18 && age < 65)
                {
                    Console.WriteLine("You are an adult.");
                }
                else
                {
                    Console.WriteLine("You are a senior.");
                }
                Console.ReadKey();
            }
        }
    }*/


