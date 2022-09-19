// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Мы её уже решали на семинаре, я просто немного офрмил удобней, согласно примеру.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
/*
void ShowNums(int m, int n)
{
    if (n > m)
    {
        if (n > m) ShowNums(m, n - 1);
        Console.Write(n + ", ");
    }
    else
    {
        if (m > n) ShowNums(m, n + 1);
        Console.Write(n + ", ");
    }
}
    Console.Write("input M ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("input N ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write($"M = {a}; N = {b} -> ");
    ShowNums(a, b);
    */
    //_________________________________________________________________________________________________________
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int SumNums(int a, int b)
{
    if (a < b) return SumNums(a + 1, b) + a;
    else return a;
}

Console.Write("input M ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("input N ");
int j = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {i}; N = {j} -> {(SumNums(i,j))}");
*/
//_____________________________________________________________________________________________________________
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

// условие 1 (n+1, при условии, что m=0)
// условие 2 (A(m-1, 1), при условии, что m>0, n=0)
// условие 3 (A(m-1, A(m, n-1), при условии, что m>0 и n>0)
/*
int Akkerman(int a, int b)
{
    if (a == 0) return b + 1;
    if (a > 0 && b == 0) return Akkerman(a - 1, 1);
    if (a > 0 && b > 0) return Akkerman(a - 1, Akkerman(a, b - 1));
return Akkerman(a, b);
}
Console.Write("input m: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("input n: ");
int j = Convert.ToInt32(Console.ReadLine());

Console.Write($"m = {i}; n = {j} -> A({i},{j}) = {(Akkerman(i,j))}");
*/