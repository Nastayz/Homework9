/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetNumber(string message) {
    int result = 0;
    while(true) {
        Console.WriteLine(message);

        if ((int.TryParse(Console.ReadLine(), out result)) && (result > 0)) {
            break;
        }
        else {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }
    return result;
}

int Sum (int m, int n, int sum) {
    if (m <= n) sum = Sum(m+1,n,sum) + m;
    return sum;
}



int M = GetNumber("Введите значение натуральное число M ");
int N = GetNumber("Введите значение натуральное число N (N>M) ");

if (M < N) {
    int sumMN = Sum(M,N,0);
    Console.WriteLine ($"{sumMN}");
}
else Console.WriteLine ($"Ошибка! {N} <= {M}");