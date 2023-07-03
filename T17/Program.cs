// Напишите программу, которая принимает на вход координаты
// точки (X, Y), причем X неравно нулю и Y неравно нулю, и
// выдает номер четвертиплоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X = ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Y = ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

if (xCoordinate > 0 && yCoordinate > 0)
{
    Console.WriteLine("Укаанные координаты соответствуют 1 четверти");
}
else if (xCoordinate < 0 && yCoordinate > 0)
{
    Console.WriteLine("Укаанные координаты соответствуют 2 четверти");
}
else if (xCoordinate < 0 && yCoordinate < 0)
{
    Console.WriteLine("Укаанные координаты соответствуют 3 четверти");
}
else if (xCoordinate > 0 && yCoordinate < 0)
{
    Console.WriteLine("Укаанные координаты соответствуют 4 четверти");
}
else Console.WriteLine("Введены некорректные координаты");
// Console.WriteLine("Hello, World!");
