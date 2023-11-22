// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//star pattern problem 1

for (int i = 1; i <= 5; i++)
{
    for (int j = 5; j >= i; j--)
    {
        Console.Write("* ");
    }

    Console.WriteLine();
}


    //star pattern problem 2

    for (int i = 1; i <= 5; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("* ");
        }

        Console.WriteLine();

    }

    //star pattern problem 3

    for (int i = 1; i <= 3; i++)
    {
        for (int j = 3; j >= i; j--)
        {
            Console.Write(" ");
        }
        for (int j = 1; j <= i; j++)
        {
            Console.Write("* ");
        }

        Console.WriteLine();
    }

    //star pattern problem 4

    string[] alphabet = { "A A A A A", "B B B B B", "C C C C C", "D D D D D", "E E E E E" };
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(alphabet[i]);
    }






Console.ReadKey();





   