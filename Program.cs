//Задача 64: Задайте значения A и B. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int min = Math.Min(A, B); // определяем первый элемент массива
int max = Math.Max(A, B); // определяем последний элемент массива
// int size = max - min + 1; //определяем длину массива

string PrintNumbers (int start, int end)
{
    if (start == end) return start.ToString();
    return (start + "; " + PrintNumbers(start+1, end));
}
Console.WriteLine($"Массив с числами между {min} и {max}: [{PrintNumbers(min, max)}]");

int SumNumbers (int start, int end)
{
    if (start == end) return start;
    return (start + SumNumbers(start+1, end));  
}
Console.WriteLine($"Сумма натуральных элементов в промежутке между {min} и {max} равна: [{SumNumbers(min, max)}]");

//решение без рекурсии
// int[] array = GetArray(size, min, max);
// Console.WriteLine($"Массив с числами между {min} и {max}: [{String.Join("; ", array)}]");
// int[] GetArray(int size, int min, int max)
// {
//     int start = min;
//     int[] array = new int[size]; // Изначально массив заполнен нулями
//     for (int i = 0; i < size; i++) // array.Length
//     {
//         array[i] = start;
//         start ++;
//     }
//     return array;
// }


// // Задача 66: Задайте значения A и B. 
// // Напишите программу, которая найдёт сумму натуральных элементов в промежутке от A до B.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// int GetSumArray (int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         sum = sum + array[i];
//     }
//     return sum;
// }

// Console.WriteLine($"Сумма натуральных элементов в промежутке между {min} и {max} равна {GetSumArray(array)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

int Ack (int n, int m)
{
    if(n==0) return m+1;
    else if ((m == 0) && (n != 0)) return Ack(n-1,1);
    else return ( Ack (n-1, Ack(n, m-1)));
}
Console.WriteLine($"Функция Анкермана для чисел {n} и {m} равна {Ack(n, m)}");
