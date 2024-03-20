/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет
все натуральные числа в промежутке от M до N.
Использовать рекурсию, не использовать циклы.
*/

// void GetSumDigit(int n, int m){
//     if (n < m){
//         return;
//     }
//     GetSumDigit(n - 1, m);
//     Console.Write(n+" ");
// }

// Console.Clear();
// int m = 2;
// int n = 8;
// GetSumDigit (n, m);


/*
Задача 2: Напишите программу вычисления функции Аккермана
с помощью рекурсии. Даны два неотрицательных числа m и n.
*/

int Akkerman(int m, int n){
    if (m == 0){
        return n + 1;
    }
    else if (n == 0){
        return Akkerman(m - 1, 1);
    }
    else {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

Console.Clear();
int m = 3;
int n = 2;
Console.Write(Akkerman(m, n));
