// Напишите программу, которая принимает на вход число
// N и выдает таблицу квадратов чисел от 1 до N
// пространстве
// 5 -> 1, 4, 9, 25
// 2 -> 1, 4

// =======================
void TableSquar(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.Write(count);
        Console.WriteLine($"   {count * count}");
        count ++;
    }

}






Console.WriteLine("Введите целое положительное число:");
Console.Write("N = ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) 
{
    TableSquar(number);
}
else Console.WriteLine("Ошибка ввода");
