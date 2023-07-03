// Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D
// пространстве
// A (3, 6); B (2, 1) -> 5,09
// A (7, -5); B (1, -1) -> 7,21

// =======================
double Distance(int x1, int y1, int x2, int y2)
{
    double result = 0;
    int catet1 = (x2 - x1);
    int catet2 = (y2 - y1);
    
    result = Math.Sqrt(catet1 * catet1 + catet2 * catet2);
    return result;
}
// =======================

Console.WriteLine("Введите координаты первой точки:");
Console.Write("X1 = ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("X2 = ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1Coordinate, x2Coordinate, y1Coordinate, y2Coordinate);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками равна {resRound}");
