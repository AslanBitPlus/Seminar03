// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// =======================
double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double result = 0;
    int catet1 = (x2 - x1);
    int catet2 = (y2 - y1);
    int catet3 = (z2 - z1);
    
    result = Math.Sqrt(catet1 * catet1 + catet2 * catet2 + catet3 * catet3);
    return result;
}
// =======================

Console.WriteLine("Введите координаты первой точки:");
Console.Write("X1 = ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 = ");
int z1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("X2 = ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 = ");
int z2Coordinate = Convert.ToInt32(Console.ReadLine());

double res = Distance(x1Coordinate, x2Coordinate, y1Coordinate, y2Coordinate, z1Coordinate, z2Coordinate);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками равна {resRound}");
