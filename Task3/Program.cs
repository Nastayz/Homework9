/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/


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

static int AkkerNum(int n, int m) {
    if (n == 0) return (m + 1);
  else {
    if ((n != 0) && (m == 0)) return AkkerNum((n - 1), 1);
    else                      return AkkerNum(n - 1, AkkerNum(n, (m - 1)));
    }
}


int M = GetNumber("Введите значение не отрицательное число M ");
int N = GetNumber("Введите значение не отрицательное число N ");

int akkermanNumber = AkkerNum(M,N);
Console.WriteLine ($"{akkermanNumber}");
