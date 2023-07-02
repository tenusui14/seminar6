// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)  
// Формула : y = ax+c  и y = bx + d;  или ax+c = bx+d
//  найти х = d-c/a-b (в нашем случае x = k2 - b1/ k1 - b2)
// найти y = k1*(k2 - b1/ k1 - b2)+ b1;
// координата равна ((k2 - b1/ k1 - b2), k1*(k2 - b1/ k1 - b2)+ b1);
//жесть

// const int CONSTANT = 1;
// const int COEFFICIENT = 0;
// const int xCoord = 0;
// const int yCoord = 1;
// const int line1 = 1;
// const int line2 = 2;


// double Input(string message)
// {
//     Console.Write(message);
//     string? value = Console.ReadLine();
//     double result = Convert.ToDouble(value);
//     return result;
// }

// double[] InputLineData(int numberOfLine){
//     double[] lineData = new double[2];
//     lineData[COEFFICIENT] = Input($"Введите коэфф для {numberOfLine} прямой ");
//     lineData[CONSTANT] = Input($"Введите конст для {numberOfLine} прямой ");
//     return lineData;
// }
// double[] FindCoords(double[] linedata1, double[] linedata2){
//     double[] coord = new double[2];
//     coord[xCoord] = (linedata1[CONSTANT] - linedata2[CONSTANT]) / (linedata2[COEFFICIENT] - linedata1[COEFFICIENT]);
//     coord[yCoord] = linedata1[CONSTANT] * coord[xCoord] + linedata1(COEFFICIENT);
//     return coord;
// }

// double[] lineData1 = InputLineData(line1);
// double[] lineData2 = InputLineData(line2);