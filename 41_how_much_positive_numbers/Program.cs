// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int FillArrayAndFindHowMuchPositiveNumbers(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string temp = array[i];
        int temp1 = Convert.ToInt32(temp);
        if (i == array.Length - 1)
        {
            Console.Write(temp);
        }
        else
        {
            Console.Write(temp);
            Console.Write(", ");
        }
        if (temp1 > 0) count++;
    }
    return count;
}

string[] CreateArray(string text)
{
    Console.Write("Введите числа через запятую: ");
    return Console.ReadLine().Split(',');
}

string[] array = CreateArray("Введите числа через запятую: ");
int count = FillArrayAndFindHowMuchPositiveNumbers(array);
Console.WriteLine($" -> {count}");