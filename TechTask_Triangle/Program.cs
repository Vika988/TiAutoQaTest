Console.WriteLine("Write coordinate x of dot A:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write coordinate y of dot A:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write coordinate x of dot B:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write coordinate y of dot B:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write coordinate x of dot C:");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write coordinate y of dot C:");
double y3 = Convert.ToDouble(Console.ReadLine());

double precision = 0.1;

double ab = Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)));
double bc = Math.Sqrt(Math.Pow(x3 - x2, 2) + (Math.Pow(y3 - y2, 2)));
double ac = Math.Sqrt(Math.Pow(x3 - x1, 2) + (Math.Pow(y3 - y1, 2)));

String equilateral = "NOT ";
if (Math.Abs(ab - bc) < precision && Math.Abs(bc - ac) < precision)
{
    equilateral = "";
}

String isosceles = "NOT ";
if (Math.Abs(ab - bc) < precision || Math.Abs(bc - ac) < precision || Math.Abs(ac - ab) < precision)
{
    isosceles = "";
}

Boolean isRight = CalculateIsRightTriangle(ab, bc, ac);
String right = "NOT ";
if (isRight)
{
    right = "";
}

double perimeter = ab + bc + ac;

Console.WriteLine(" ");
Console.WriteLine("Length of AB is: '" + ab + "'");
Console.WriteLine("Length of BC is: '" + bc + "'");
Console.WriteLine("Length of AC is: '" + ac + "'");
Console.WriteLine(" ");
Console.WriteLine("Triangle IS " + equilateral + "'Equilateral'");
Console.WriteLine("Triangle IS " + isosceles + "'Isosceles'");
Console.WriteLine("Triangle IS " + right + "'Right'");
Console.WriteLine(" ");
Console.WriteLine("Perimeter: '" + perimeter + "'");
Console.WriteLine(" ");
Console.WriteLine("Parity numbers in range from 0 to triangle perimeter");
for (int i = 0; i <= perimeter; i = i + 2)
{
    Console.WriteLine(i);
}

Console.ReadKey();

bool CalculateIsRightTriangle(double ab, double bc, double ac)
{
    if (ab > bc && ab > ac)
    {
        double delta = Math.Pow(ab, 2) - (Math.Pow(bc, 2) + Math.Pow(ac, 2));
        return Math.Abs(delta) <= precision;
    }
    else if (bc > ab && bc > ac)
    {
        double delta = Math.Pow(bc, 2) - (Math.Pow(ab, 2) + Math.Pow(ac, 2));
        return Math.Abs(delta) <= precision;
    }
    else if (ac > ab && ac > bc)
    {
        double delta = Math.Pow(ac, 2) - (Math.Pow(ab, 2) + Math.Pow(bc, 2));
        return Math.Abs(delta) <= precision;
    }
    return false;
}