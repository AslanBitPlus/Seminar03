// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// =======================
int Polindrom(int x)
{
    int result = 0;
    // -1 число отрицательное
    // 0 число НЕ является полиндромом
    // 1 число является полиндромом

    // Определяем количество цифр
    int numeric = 1;
    int x1 = x;
    while (x1 >= 10)
    {
        x1 = x1 / 10;
        numeric ++;
    }
    // Console.WriteLine($"Введено число: {x}. Количество цифр: {numeric}.");

    // Если значность числа больше одной проверяем на соответствие полиндрому
    // Записываем число в Массив
    if (numeric > 1)
    {
        int digit = 0;
        int i = 0;
        x1 = x;
        int[] array = new int[numeric];
        while (x1 > 0)
        {
            digit = x1 % 10;
            array[numeric - 1 - i] = digit;
            // Console.Write($"{digit}");
            x1 = x1 / 10;
            i ++;
        }
        // Проверка на Полиндром
        int pol = 0;
        for (i = 0; i <= array.Length - 1; i ++)
        {
            if (array[i] != array[numeric -1 - i])
            {
                pol ++;
            }
        }
        if (pol > 0) result = -1; else pol = 1;
    } 
    
    return result;
}
// =======================


Console.WriteLine("Введите целое положительное число:");
Console.Write("N = ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 0) 
{
    int res = Polindrom(number);
    // Polindrom(number);
    // Console.WriteLine();
    if (res == 0) Console.WriteLine($"Число {number} является полиндромом");
    else Console.WriteLine($"Число {number} НЕ является полиндромом");
}
else Console.WriteLine("Ошибка ввода");
