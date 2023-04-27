internal class EjerciciosSolucion
{

    public EjerciciosSolucion() { 
    
    }


    public void ejercicio1()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Write a program to print the following to the console");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Hello World");
    }

    public void ejercicio2()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Print the words Hello & World in two separate lines.Following should be the output your program produce");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Hello\nWorld");
    }

    public void ejercicio3()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Write a program to scan the name of the user and say hello to them.");
        Console.ForegroundColor = ConsoleColor.White;

        string inputText = Console.ReadLine();

        Console.WriteLine("Hello"+" "+inputText);
    }

    public void ejercicio4()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take a character as an input and print whether it is an vowel or a consonant. Sample input and output are shown as below:");
        Console.ForegroundColor = ConsoleColor.White;

        string inputText = Console.ReadLine();

        if (inputText.Equals("a") || inputText.Equals("e") || inputText.Equals("i") || inputText.Equals("o") || inputText.Equals("u"))
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("consonant");
        }
    }

    public void ejercicio5()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Print numbers from 1 to 10 using any loop of your choice. Following is the expected output:");
        Console.ForegroundColor = ConsoleColor.White;

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void ejercicio6()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take a number between 0 to 9 as input and print the word representation for that number.");
        Console.ForegroundColor = ConsoleColor.White;

        int intNumber = Int32.Parse(Console.ReadLine());
    
        if (intNumber == 1)
        {
            Console.WriteLine("one");
        }
        else if (intNumber == 2)
        {
            Console.WriteLine("two");
        }
        else if (intNumber == 3)
        {
            Console.WriteLine("three");
        }
        else if (intNumber == 4)
        {
            Console.WriteLine("four");
        }
        else if (intNumber == 5)
        {
            Console.WriteLine("five");
        }
        else if (intNumber == 6)
        {
            Console.WriteLine("six");
        }
        else if (intNumber == 7)
        {
            Console.WriteLine("seven");
        }
        else if (intNumber == 8)
        {
            Console.WriteLine("eight");
        }
        else if (intNumber == 9)
        {
            Console.WriteLine("nine");
        }
    }

    public void ejercicio7()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Read two numbers as input and print the sum of the two given numbers. Sample input and output are shown as below");
        Console.ForegroundColor = ConsoleColor.White;

        int intNumberOne = Int32.Parse(Console.ReadLine());
        int intNumberTwo = Int32.Parse(Console.ReadLine());

        Console.WriteLine(intNumberOne + intNumberTwo);
    }

    public void ejercicio8()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take two numbers as input from the user and print the largest number out of those two numbers.");
        Console.ForegroundColor = ConsoleColor.White;

        int intNumberOne = Int32.Parse(Console.ReadLine());
        int intNumberTwo = Int32.Parse(Console.ReadLine());

        if (intNumberOne > intNumberTwo)
        {
            Console.WriteLine(intNumberOne);
        }
        else
        {
            Console.WriteLine(intNumberTwo);
        }
    }

    public void ejercicio9()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take three numbers as input from the user and print the largest number out of those three numbers.");
        Console.ForegroundColor = ConsoleColor.White;

        int intNumberOne = Int32.Parse(Console.ReadLine());
        int intNumberTwo = Int32.Parse(Console.ReadLine());
        int intNumberTree = Int32.Parse(Console.ReadLine());

        if (intNumberOne > intNumberTwo)
        {
            if (intNumberOne > intNumberTree)
            {
                Console.WriteLine(intNumberOne);
            }
        }


        if (intNumberTwo > intNumberTree)
        {
            Console.WriteLine(intNumberTwo);
        }
        else
        {
            Console.WriteLine(intNumberTree);
        }
    }

    public void ejercicio10()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take a year as input and tell whether or not it's a leap year.\r\nPrint yes If it's a leap year and print no if it's not a leap year.");
        Console.ForegroundColor = ConsoleColor.White;

        int intYear = Int32.Parse(Console.ReadLine());

        if ((intYear % 4 == 0 || intYear % 100 == 1 && intYear % 400 == 0))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

    }

    public void ejercicio11()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take two numbers as put from the user and multiply them, print the value.");
        Console.ForegroundColor = ConsoleColor.White;

        int intNum = Int32.Parse(Console.ReadLine());
        int intNum2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine(intNum * intNum2);
    }

    public void ejercicio12()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take a number as input and tell its positive or negative");
        Console.ForegroundColor = ConsoleColor.White;

        int intNum = Int32.Parse(Console.ReadLine());

        if (intNum < 0)
        {
            Console.WriteLine("negative");
        }
        else
        {
            Console.WriteLine("positive");
        }
    }

    public void ejercicio13()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take a number as input and calculate the square of that number");
        Console.ForegroundColor = ConsoleColor.White;

        int intNumber = Int32.Parse(Console.ReadLine());

        Console.WriteLine(intNumber * intNumber);
    }

    public void ejercicio14()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take a number as input and tell its even or odd number");
        Console.ForegroundColor = ConsoleColor.White;

        int intNunmber = Int32.Parse(Console.ReadLine());

        if (intNunmber % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
    }

    public void ejercicio15()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take 3 numbers from the input and print the average of those numbers");
        Console.ForegroundColor = ConsoleColor.White;

        int intNumber1 = Int32.Parse(Console.ReadLine());
        int intNumber2 = Int32.Parse(Console.ReadLine());
        int intNumber3 = Int32.Parse(Console.ReadLine());

        Console.WriteLine((intNumber1 + intNumber2 + intNumber3) / 3);
    }

    public void ejercicio16()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take a number (n) as input and print sum of the n natural numbers");
        Console.ForegroundColor = ConsoleColor.White;

        int intNumber = Int32.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i <= intNumber; i++)
        {
            count = count + i;
        }
        Console.WriteLine(count);
    }

    public void ejercicio17()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take a number as an input and print the factorial of that number.");
        Console.ForegroundColor = ConsoleColor.White;

        int intNumb = Int32.Parse(Console.ReadLine());
        int intResultado = 1;

        for (int i = intNumb; i > 0; i--)
        {
            intResultado = intResultado * i;
        }

        Console.WriteLine(intResultado);
    }

    public void ejercicio18()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Take a number as input and print the square root of that number.");
        Console.ForegroundColor = ConsoleColor.White;

        double intNumber = Convert.ToDouble(Console.ReadLine());
        double resultado = Math.Sqrt(intNumber);

        Console.WriteLine(resultado);
    }

    public void ejercicio19()
    {

    }

    public void ejercicio20()
    {

    }
}