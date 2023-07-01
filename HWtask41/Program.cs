// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int Input(string message)
{
    Console.Write(message);
    string? value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int[] CreateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Input($"Введите {i + 1}-й элемент: ");
    }
    return array;
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


int length = Input("Введите количество элементов: ");
int[] myArray = CreateArray(length);
Console.WriteLine($"[ {string.Join(", ", myArray)} ]");
Console.WriteLine($"Количество чисел > 0 = {CountPositive(myArray)}");