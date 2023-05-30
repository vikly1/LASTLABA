using System;
using System.Linq.Expressions;

int[] array = new int[100];
Random random = new Random();
int sum = 0;
double sum2 = 1;
int sum3 = 0;
selectopers();

void selectopers()
{
    Console.WriteLine("Выберите одну из операций \n 1. Посмотреть массив \n 2. Заполнить массив случайными числами \n 3. Среднее арифметическое массива \n 4. Среднее геометрическое массива \n 5. Среднее квадратичное массива");
    var keycheck = Console.ReadKey().Key;
    Console.WriteLine();
    switch (keycheck)
    {
        case ConsoleKey.D1:
            check();
            break;
        case ConsoleKey.D2:
            fill();
            break;
        case ConsoleKey.D3:
            arifm();
            break;
        case ConsoleKey.D4:
            geom();
            break;
        case ConsoleKey.D5:
            squ();
            break;
        default:
            selectopers();
            break;
    }
}
void fill()
{
    Console.WriteLine("Массив заполнен случайными числами");
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(1, 100);
    selectopers();
}
void check()
{
    Console.WriteLine("ваш массив");
    foreach (int i in array)
        Console.Write($"{i}  ");
    Console.WriteLine();
    selectopers();
}
void arifm()
{
    sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    double sumarifm = Convert.ToDouble(sum);
    sumarifm /= array.Length;
    Console.WriteLine($"Среднее арифметическое \n {sumarifm}");
    Array.Clear(array);
    Console.WriteLine();
    selectopers();
}
void geom()
{
    sum2 = 1;
    for (int i = 0; i < array.Length; i++)
    {
        sum2 *= array[i];
    }
    double geomsum = Math.Pow((sum2), 1.0 / Convert.ToDouble(array.Length));
    Console.WriteLine($"Среднее геометрическое \n {geomsum}");
    Array.Clear(array);
    Console.WriteLine();
    selectopers();
}

void squ()
{
    sum3 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum3 += i * i;
    }
    double squsum = Math.Pow(Convert.ToDouble(sum2) / array.Length, 1.0 / 2.0);
    Console.WriteLine($"Среднее квадратичное \n {squsum}");
    Console.WriteLine();
    selectopers();
}


