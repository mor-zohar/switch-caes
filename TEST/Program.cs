// See https://aka.ms/new-console-template for more information

double a, b;
int c;

Console.WriteLine("Enter A Number:");
double.TryParse(Console.ReadLine(), out a);

Console.WriteLine("Enter A Number:");
double.TryParse(Console.ReadLine(), out b);

Console.WriteLine("Enter A Number 1-7:\n");
Console.WriteLine("1) Plus\n2) Minus\n3) Duplicate\n4) Division\n5)Squared Increase\n6)Square Root\n7)Absolute  ");
int.TryParse(Console.ReadLine(), out c);


switch (c)
{
    case 1:
        Console.WriteLine($"\n{a}+{b}={a + b}\n");
        break;
    case 2:
        Console.WriteLine($"\n{b}-{a}={b - a}\n");
        break;
    case 3:
        Console.WriteLine($"\n{a}*{b}={a * b}\n");
        break;
    case 4:
        Console.WriteLine($"\n{a} / {b} = {a / b}\n");
        break;
    case 5:
        Console.WriteLine($"\n{a} + {b} = {a + b}^2 = {Math.Pow(a + b, 2)}\n");
        break;
    case 6:
        Console.WriteLine($"\n{a} Square = {Math.Sqrt(a)}\n");
        break;
    case 7:
        Console.WriteLine($"\n{b}-{a} = {b - a} - Absolute = {Math.Abs(b - a)}\n");
        break;

}
