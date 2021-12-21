// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter radius of circle: ");
double circle_radius = Convert.ToDouble(Console.ReadLine());
double circle_perimeter = circle_radius * 2 * Math.PI;

Console.WriteLine($"Perimeter of Circle: {circle_perimeter}");
