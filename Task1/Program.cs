/*Задача 64: Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

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

void PrintNumber(int N, int i) {
    if (i > 0) {
        
        Console.Write($"{i} ");
        i--;
        PrintNumber(N, i);
    }
}


int N = GetNumber("Введите значение натуральное число ");
int i=N;
PrintNumber(N,i);

