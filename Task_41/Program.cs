/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.Clear();
Console.Write($"Введите произвольное количество чисел через пробел и нажмите Enter: ");
int[] str = (Console.ReadLine() ?? "0").Split().Select(int.Parse).ToArray();
Console.Write($"Поместим числа в массив: ");

void PrinArray(int[] array)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < str.Length - 1) Console.Write(str[i] + ",");
        else Console.Write(str[i] + "]");
    }
}
int MoreZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}

PrinArray(str);
Console.WriteLine();
int res = MoreZero(str);
Console.Write($"Вы ввели {res} чисел(о) больше нуля");