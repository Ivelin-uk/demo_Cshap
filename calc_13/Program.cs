﻿//•	area = Math.PI * r * r
//•	perimeter = 2 * Math.PI * r

double r = double.Parse(Console.ReadLine());
//double area = Math.PI * Math.Pow(r, 2);
double area = Math.PI * r * r;
double perimeter = 2 * Math.PI * r;

Console.WriteLine($"Area: {area:F2}");
Console.WriteLine($"Perimeter: {perimeter:F2}");