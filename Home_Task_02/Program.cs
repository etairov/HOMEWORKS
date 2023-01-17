//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7 44 5 78 -> 78 22 3 9 -> 22

Console.WriteLine("Введите число A");
string numberStrA = Console.ReadLine();
Console.WriteLine("Введите число B");
string numberStrB = Console.ReadLine();
Console.WriteLine("Введите число C");
string numberStrC = Console.ReadLine();

int A = Convert.ToInt32(numberStrA);
int B = Convert.ToInt32(numberStrB);
int C = Convert.ToInt32(numberStrC);
int Max = A;

if (B > A)
    Max = B;
if (C > Max)
    Max = C;

Console.WriteLine(A + ", " + B + ", " + C);
Console.WriteLine("Max = " + Max);