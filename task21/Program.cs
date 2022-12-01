// See https://aka.ms/new-console-template for more information
//double n =Math.Sqrt(25);
//Console.WriteLine(n);

Console.WriteLine("Введите координатную точку A по X");
int xa = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координатную точку A по Y");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координатную точку B по X");
int xb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координатную точку B по Y");
int yb = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));

Console.WriteLine($"{res:F2}");