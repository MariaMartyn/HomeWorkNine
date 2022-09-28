// Задача 64: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
/*
void NatureNumbers (int m, int n)
{
    Console.Write(m + " ");
    if (m < n) NatureNumbers(m+1, n);
    else if (m >= n) Console.WriteLine("This segment is not");
}
    Console.Write("Input m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    NatureNumbers (m, n);
*/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
/*
int SumOfDigut(int m, int n)
{
        if(n == m) return n;
        else return m + SumOfDigut(m + 1, n);
}

 Console.Write("Input number m: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input number n: ");
 int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfDigut(m, n));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
/*
int FunctionAccerman(int m, int n)
{
    if (m == 0) return n + 1;
        if (m > 0 && n == 0) return FunctionAccerman(m - 1, 1);
            if (m > 0 && n > 0) return FunctionAccerman(m - 1, FunctionAccerman(m, n - 1));
    return FunctionAccerman(m, n);
}

 Console.Write("Input positive number m: ");
 int m = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input positive number n: ");
 int n = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine(FunctionAccerman(m, n));
 */