//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
//--------------------------------

Console.WriteLine("Введите число A");
string numberStrA = Console.ReadLine();
Console.WriteLine("Введите число B");
string numberStrB = Console.ReadLine();

int numberA = Convert.ToInt32(numberStrA);
int numberB = Convert.ToInt32(numberStrB);
int Max = 0;

if (numberA > numberB) Max = numberA;
    else
    {
        Max = numberB;
    }
Console.WriteLine("A = " + numberA + ", B = " + numberB + ", Max =" + Max);
