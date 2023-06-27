// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Input(){
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
return num;
}

int[] Fibonacci(int num){
    int [] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < array.Length; i++){
        array[i] = array[i-1] + array[i-2];
    }
return array;
}

int number = Input();
int[] myArray = Fibonacci(number);
Console.WriteLine($"Первые {number} чисел Фибоначчи = [ {string.Join(", ", myArray)} ] ");