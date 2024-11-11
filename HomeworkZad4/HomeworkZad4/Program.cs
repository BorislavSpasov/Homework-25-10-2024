using System.Net.WebSockets;
using System.Xml.Schema;

int sideA, sideB, sideC;

//Checking if the input is valid
try
{
    sideA = int.Parse(Console.ReadLine());
    sideB = int.Parse(Console.ReadLine());
    sideC = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Invalid input!");
    return;
}

// Checking if a triangle can actually be made from the values that are input

if ((sideA <= 0 || sideB <= 0 || sideC <= 0) ||
    (sideA + sideB >= sideC || sideB + sideC >= sideA || sideA + sideC >= sideB))
{
    // Checking what kind of triangle it is
    if ((sideA + sideB == sideC) ||
        (sideB + sideC == sideB) ||
        (sideC + sideA == sideA))
    {
        Console.WriteLine("The triangle is a degenerate triangle!");
    }
    else if (sideA == sideB && sideB == sideC)
    {
        Console.WriteLine("The triangle is a equilateral triangle!");
    }
    else if (sideA == sideB ||
        sideB == sideC ||
        sideC == sideA)
    {
        Console.WriteLine("The triangle is a isosceles triangle!");
    }
    else
    {
        Console.WriteLine("The triangle is a scalene triangle!");
    }
}
else
{
    Console.WriteLine("You cant make a triangle using those values");
    return;
}