// Напишите программу, которая принимает на вход координаты
// точки (X, Y), причем X неравно нулю и Y неравно нулю, и
// выдает номер четвертиплоскости, в которой находится эта точка.

int FindQuarter(int x, int y)
{
    int result = 0;
    if (x > 0 && y > 0) result = 1;
    else if (x < 0 && y > 0) result = 1;
    else if (x < 0 && y < 0) result = 2;
    else if (x > 0 && y < 0) result = 3;
    return result;
}


Console.WriteLine("Введите координаты точки");
Console.Write("X = ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Y = ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int findQuarter = FindQuarter(xCoordinate, yCoordinate);
if (findQuarter != 0) 
{
    Console.WriteLine($"Точка принадлежит четверти {findQuarter}");
}
else Console.WriteLine("Введены неверные координаты");

