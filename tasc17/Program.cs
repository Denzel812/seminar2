// See https://aka.ms/new-console-template for more information
//onsole.WriteLine("Hello, World!");
Console.WriteLine("Введите коорденаты по точке X");
int X= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординаты по точке Y");
int Y = Convert.ToInt32(Console.ReadLine());

if (X>0 && Y>0)
{
    Console.WriteLine("Точка находиться в первой координатной четверти");
}
else if (X>0 && Y<0)
{
    Console.WriteLine("Точка находиться во второй координатной чертвити");
}
else if (X<0 && Y<0)
{
    Console.WriteLine("Точка находиться в третий координатной четверти");
}
else if (X<0 && Y>0)
{
    Console.WriteLine("Точка находиться в четвёртой координатной четверти");
}
else
{
    Console.WriteLine("Такой координатной четверти не существует");
}













