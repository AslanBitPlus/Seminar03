// Напишите программу, которая по заданному номеру четверти,
// показывает диаппазон возможных координат точек в этой
// четверти (X, Y)
// =======================
string Quarter(int x)
{
    string result = "Введен неправилный номер четверти";
    if (x == 1 ) result = "X > 0, Y > 0";
    else if (x == 2 ) result = "X < 0, Y > 0";
    else if (x == 3) result = "X < 0, Y < 0";
    else if (x == 4) result = "X > 0, Y < 0";
    return result;
}
// =======================

Console.Write("Введите номер четверти: ");
int quorterNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Quarter(quorterNumber));



