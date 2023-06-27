// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
int Input(){
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
return num;
}
bool Calculations(int num1, int num2, int num3){
if(num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
return true;
else return false;
}
int numberA = Input();
int numberB = Input();
int numberC = Input();

if(Calculations(numberA,numberB,numberC) != false ){
    Console.WriteLine("Такой треугольник может существовать");
}
else Console.WriteLine("Такой треугольник не может существовать");