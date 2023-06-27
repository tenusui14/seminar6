// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int Input(){
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
return num;
}

string Calculations(int number){
string message = "";
int i = 0;
    while(number != 0){
      i = number % 2;
      number /= 2;
      message = i + message; 
    }
    return message;
}
 int number = Input();
 string message = Calculations(number);
 Console.WriteLine(message);



