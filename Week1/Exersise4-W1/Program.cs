// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter radius of circle: ");
double RadiusOfCircle = Convert.ToDouble(Console.ReadLine());
double PerimeterOfCircle = RadiusOfCircle * 2 * Math.PI;

Console.WriteLine($"Perimeter of Circle: {PerimeterOfCircle}");
