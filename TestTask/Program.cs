using TestTask.Shapes;
using TestTask.Shapes.Abstract;

double diameter;
string? input;
try
{
    do
    {
        Console.WriteLine("Enter diameter of the round:");
        input = Console.ReadLine();
    }
    while (!double.TryParse(input, out diameter));
    
    Round r = new(diameter);
    Console.WriteLine($"Square value of round with diameter {diameter} is {r.GetSquare()}");
    Console.WriteLine("----------------------------");
    Console.WriteLine("Enter sides of the triangle:");

    double sideA, sideB, sideC;
    do
    {
        Console.WriteLine("Side A:");
        input = Console.ReadLine();
    }
    while (!double.TryParse(input, out sideA));

    Console.WriteLine("Side A is correct");
    do
    {
        Console.WriteLine("Side B:");
        input = Console.ReadLine();
    }
    while (!double.TryParse(input, out sideB));

    Console.WriteLine("Side B is correct");

    do
    {
        Console.WriteLine("Side C:");
        input = Console.ReadLine();
    }
    while (!double.TryParse(input, out sideC));
    Triangle t = new(sideA, sideB, sideC);
    Console.WriteLine("Side C is correct");
    Console.WriteLine($"Square value of triangle with sides {sideA},{sideB},{sideC} is {t.GetSquare()}");
}
catch(Exception exc)
{
    Console.WriteLine(exc.Message);
}
Console.ReadKey();