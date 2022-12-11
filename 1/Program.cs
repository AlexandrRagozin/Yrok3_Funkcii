// // Напишите программу, которая принимает на вход число А и выдает сумму числел от 1 до А

// int GetSum(int A) 
// {
//     int sum = 0;

//     for (int i = 1; i <= A; i++)
//     {
//         sum += i;
//     }

//     return sum;
// }    

// Console.Write("Введите число А: ");

// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(GetSum(N));



// Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// int Count(int A)
// {
//     int rez = 0;
//     while (A != 0)
//     {
//         A /= 10;
//         rez++;
//     }



//     return rez;
// }

// Console.Write("Введите число: ");

// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(Count(N));


// Задача 28: напишите программу, которая принимает на вход число N и выдает  произведение чисел от 1 до N

// int GetProd(int A)
// {
//     int prod = 1;

//     for (int i = 1; i <= A; i++)
//     {
//         prod *= i;
//     }

//     return prod;
// }

// Console.Write("Введите число А: ");

// int N = int.Parse(Console.ReadLine()!);

// Console.WriteLine(GetProd(N));


// Задача 30: : Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int [] GetArray()
{
    int [] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
    
}
var str = string.Join(", ", GetArray());

Console.WriteLine("[" + str + "]");













