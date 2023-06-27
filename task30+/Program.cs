﻿//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetRandomArray(int lenght, int leftRange, int rightRange){
    int [] array = new int[lenght];
    for(int i = 0; i < array.Length; i++){
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

void ReverseArray(int [] array){
    for(int i = 0; i < array.Length / 2; i++){
        int temp = array[i];
        array[i]= array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}
const int lenght = 5;
const int leftRandomBorder = -9;
const int rightRandomBorder = 10;
int [] myArray = GetRandomArray(lenght, leftRandomBorder, rightRandomBorder);
Console.WriteLine(string.Join(", ", myArray));
ReverseArray(myArray);
Console.WriteLine(string.Join(", ", myArray));