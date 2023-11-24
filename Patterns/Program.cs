// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


////star pattern problem 1

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 5; j >= i; j--)
//    {
//        Console.Write("* ");
//    }

//    Console.WriteLine();
//}


//    //star pattern problem 2

//    for (int i = 1; i <= 5; i++)
//    {
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write("* ");
//        }

//        Console.WriteLine();

//    }

//    //star pattern problem 3

//    for (int i = 1; i <= 3; i++)
//    {
//        for (int j = 3; j >= i; j--)
//        {
//            Console.Write(" ");
//        }
//        for (int j = 1; j <= i; j++)
//        {
//            Console.Write("* ");
//        }

//        Console.WriteLine();
//    }

//    //star pattern problem 4

//    string[] alphabet = { "A A A A A", "B B B B B", "C C C C C", "D D D D D", "E E E E E" };
//    for (int i = 0; i < 5; i++)
//    {
//        Console.WriteLine(alphabet[i]);
//    }



//star pattern problem 5

for (int j=1; j <= 2; j++)
{
    for (int k = j; k <= 1; k++)
    {
        Console.Write("  ");
    }
    for (int i = 1; i <= 2 * j - 1; i++)
    {
        Console.Write(" *");
    }

    Console.WriteLine();

}
for (int j = 1; j <= 2; j++)
{
    for (int k = j; k <= 1; k++)
    {
        Console.Write("  ");
    }
    for (int i = 1; i <= 2 * j - 1; i++)
    {
        Console.Write(" *");
    }

    Console.WriteLine();

}
Console.WriteLine("   *");



//second solution OR


for (int j=1; j <= 5; j++)
{
    if (j % 2 == 1)
    {
        Console.WriteLine(" *");
    }
    else
    {
        Console.WriteLine("***");
    }
}




Console.ReadKey();





   