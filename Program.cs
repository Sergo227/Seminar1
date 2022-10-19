
/*int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;

//int result = Convert.ToInt32(Math.Pow(number, 2));

Console.WriteLine("Квадрат от числа " + number + " = " + square);*/

/*Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine(firstNumber + " является квадратом от " + secondNumber);
}
else Console.WriteLine(firstNumber + " НЕ является квадратом от " + secondNumber);*/

/*int number = Convert.ToInt32(Console.ReadLine());
int negativeNumber = number*(-1);

while (negativeNumber <= number)
{
    Console.Write(negativeNumber + " ");
    negativeNumber++;
}*/


// Задача 2

/*Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine(firstNumber + " - большее число");
    Console.WriteLine(secondNumber + " - меньшее число");
}
else  Console.WriteLine(secondNumber + " - большее число");
 Console.WriteLine(firstNumber + " - меньшее число");*/

// Задача 4

/*Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

 if (number1 >= number2)
 {
    if (number3 >= number1)
    {
       max = number3;
       Console.WriteLine(number3 + " - максимум");
    }
    else
    {
       max = number1;
       Console.WriteLine(number1 + " - максимум");
    }
 }
 else
 {
    if (number3 >= number2)
    {
       max = number3;
       Console.WriteLine(number3 + " - максимум");
    }
    else
    {
       max = number2;
       Console.WriteLine(number2 + " - максимум");
    }
 }*/

 // Задача 6

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2==0)
{
    Console.WriteLine(number + " - четное число");
}
else Console.WriteLine(number + " - нечетное число");*/

// Задача 8

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (i % 2==0)
    {Console.Write(i + " ");}
} */


//Классная работа, 2 семинар


/*int number = new Random().Next(10,100);
Console.WriteLine("Рандовное число: " + number);

int firstDigit = number / 10;
int secondDigit = number % 10;

int maximum = firstDigit;
if (maximum < secondDigit) maximum = secondDigit;

Console.WriteLine ($"Максимальное цифра в числе {number} - это {maximum}" ); // Интерполяция
// Конкатенация - складывает строчки, интерполяция преобразует содержание в строчку*/

//Классная работа. Задача 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98
/*int number = new Random().Next(100, 999);
Console.WriteLine("Рандомное число: " + number);

int firstDigit = number / 100;
int secondDigit = number % 10;
int result = firstDigit * 10 + secondDigit;

Console.WriteLine (result);*/

//Классная работа. Задача 2. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

/*Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0)
{
   Console.WriteLine ($"Число {firstNumber} кратно числу {secondNumber}");
}
else
{
   int result = firstNumber % secondNumber;
   Console.WriteLine ($"Число {firstNumber} некратно числу {secondNumber} остаток от деления - {result}");
}*/

//Классная работа. 3 задача. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 14 -> нет 46 -> нет 161 -> да

/*Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{ Console.WriteLine ($"{number}  -> да"); }

else
{
   Console.WriteLine ($"{number}  -> нет");
}*/
//1. String

/*string inputNumber = Console.ReadLine(); // "456"
Console.WriteLine($"{inputNumber[0]}{inputNumber[2]}");*/

// 2 int

/*int number = new Random().Next (100, 1000);
int result = (number/100) *10 + number %10;

Console.WriteLine($"Исходное число: {number}, результат: {result}");*/

/*Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{ Console.WriteLine ($"{number}  -> да"); }

else
{
   Console.WriteLine ($"{number}  -> нет");
}*/

/*Домашнее задание:
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

/*Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number % 100 / 10;

Console.WriteLine(number1);*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/*Console.Write("Введите число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
string inputNumberText = Convert.ToString(inputNumber);

if (inputNumberText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + inputNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}*/

//Классная работа

/*Console.Write("Введите координату по оси oX: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси oY: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0) Console.WriteLine("I четверть");
else if (x < 0 && y > 0) Console.WriteLine("II четверть");
else if (x < 0 && y < 0) Console.WriteLine("III четверть");
else if (x > 0 && y > 0) Console.WriteLine("IV четверть");
else Console.WriteLine("error 404, quarter not found");*/

//Задача 18.

/*Console.Write("Введите номер четверти: ");
int numberOfQuarter = Convert.ToInt32(Console.ReadLine());

if (numberOfQuarter == 1) Console.WriteLine("x > 0 && y > 0");
else if (numberOfQuarter == 2) Console.WriteLine("x < 0 && y > 0");
else if (numberOfQuarter == 3) Console.WriteLine("x < 0 && y < 0");
else if (numberOfQuarter == 4) Console.WriteLine("x > 0 && y > 0");
else Console.WriteLine("error 404, quarter not found");*/

//Задача 21

/*Console.Write("Введите данные значения А по оси oX: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите данные значения А по оси oY: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите данные значения B по оси oX: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите данные значения B по оси oY: ");
int yB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2));

Console.WriteLine($"Расстояние между точками = {Math.Round(distance,2)}");*/

//Задача 22

/*Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица квадратов: ");

int i = 1;
double result = 0;
while (i <= N)
{
   result = Math.Pow(i,2);
   i ++;
   Console.WriteLine(result);
}*/

/*
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица квадратов: ");
for (int i = 1; i <= N; i++) Console.WriteLine(Math.Pow(i,2));*/

// Домашнее задание. Задача 19


/*Console.Write("Введите число: ");
string number = Console.ReadLine();

void InputNumber(string number){
if (number[0] == number[4] || number[1] == number[3])
{
   Console.WriteLine("Число: " + number + "- палиндром");
}
else Console.WriteLine("Число: " + number + "- НЕ палиндром");
}

if (number.Length == 5)
{InputNumber(number);}
else Console.WriteLine("Введите пятизначное число");*/
// Функцию void не показывали на семинаре, но показывали на лекции, немного загуглил про void и получил возвращаемое число.

// Задача 21.
/*Console.Write("Введите данные значения А по оси X: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите данные значения А по оси Y: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите данные значения А по оси Z: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите данные значения B по оси X: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите данные значения B по оси Y: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите данные значения B по оси Z: ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2) + Math.Pow((zB - zA),2));

Console.WriteLine($"Расстояние между точками = {Math.Round(distance,2)}");*/

// Задача 23

/*Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов: ");
for (int i = 1; i <= N; i++) Console.WriteLine(Math.Pow(i,3));*/

// Классная работа

/*Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= A; i++)
{
   sum += i;
}
Console.WriteLine($"Сумма элементов от 1 до {A} = {sum}");*/

//2. Через метод и цикл while

// Метод - функция, которая создается собственноручно
//Отдельный метод - 50 массивов - 50 раз вызовете метод (один метод выполняет 50 задач)
//Тип возвращаемого значения (int, string, double) NameOfMethod (params)
//GetSumNumbers - PascalCase - только для методов

/*int A = Convert.ToInt32(Console.ReadLine());
int GetSumNumbers(int number)
{
  int sum = 0;
  int start = 1;
  while(start <= number)
  {
   sum += start;
   start++;
  }
  return sum;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {GetSumNumbers(A)}");*/

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Res = number;
int count = 0;
while (Res != 0)
{
   Res = Res / 10;
   count ++;
}
Console.WriteLine(count);*/

//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

/*Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int factorial = 1;

for (int i = 1; i <= N; i++)
{
   factorial = factorial * i; 
}

Console.WriteLine(factorial);*/

//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

/*int[] mass = new int[8];

for (int i = 0; i < 8; i++)
{
   mass[i] = new Random().Next(2);
   Console.Write($"{mass[i]} ");
}*/

//26
// int number = Convert.ToInt32(Console.ReadLine());

// int GetCountNumbers(int digit)
// {
//    int count = 0;
//    while (digit > 0)
//    {
//       count++;
//       digit /= 10;
//    }
//    return count;
// }

// Console.WriteLine(GetCountNumbers(number));

//28

// int number = Convert.ToInt32(Console.ReadLine());

// int GetMultiply(int num)
// {
//    int result = 1;
//    for (int i = 2; i <= num; i++)
//    {
//      result *= i; 
//    }
//    return result;
// }
// Console.WriteLine($"Произведение чисел от 1 до {number} = {GetMultiply(number)}");

//30

// int[] GetBinaryArray(int size)
// {
//    int [] result = new int[size];
//    for (int i = 0; i < size; i++) // size = result.Length
//    {
//       result[i] = new Random().Next(0,2);
//    }
//    return result;
// }

// int [] testArray = GetBinaryArray(8);
// Console.WriteLine($"Результат: [ {String.Join("; ", testArray)} ]");

// Домашняя работа по семинару 4.
//Задача 25
// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());

// double result = Math.Pow(A,B);

// Console.WriteLine($"Результат: {result}");

//Задача 27

// Console.Write("Введите число: ");
// int inputNumber = Convert.ToInt32(Console.ReadLine());
// string inputNumberText = Convert.ToString(inputNumber);
// int SummaNumber(int inputNumber)
// {
// int result = 0;
// for (int i = 0; i <= inputNumberText.Length; i++)
// {
//    result = inputNumberText[i] + inputNumberText[i+1];
// }
// return result; }
// int sumNumber = SummaNumber(inputNumber);
// Console.WriteLine($"{sumNumber}"); - Неполучившееся решение
// 
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

//   int SummaNumber(int number)
//   {
//     int variable = 0;
//     int result = 0;
//     int numberLength = Convert.ToString(number).Length;

//     for (int i = 0; i < numberLength; i++){
//       variable = number - number % 10;
//       result = result + (number - variable);
//       number = number / 10;
//       Console.WriteLine ($"{variable}");
//       Console.WriteLine ($"{result}");
//       Console.WriteLine ($"{number}");
//     }
//    return result;
//   }
// int sumNumber = SummaNumber(number);
// Console.WriteLine($"Сумма цифр в числе {number} = {sumNumber}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] mass = new int[8];

// for (int i = 0; i < 8; i++)
// {
//    mass[i] = new Random().Next(99);
// }
// Console.Write($"Результат: [ {String.Join("; ", mass)} ]");

// Классная работа. Семинар 5

// Задача 31
// int[] array = new int[12];
// int resulPositive = 0;
// int resulNegative = 0;

// int i = 0;
// int arraySize = array.Length;
// while (i < arraySize)
// {
//    array[i] = new Random().Next(-9,10);
//    i++;
// }
// Console.Write($"Array: [ {String.Join("; ", array)} ]");

// for (int j = 0; j < arraySize; j++)
// {
//    if (array[j] < 0) resulNegative += array[j];
//    else resulPositive += array[j];
// }

// Console.WriteLine($"Сумма пол. = {resulPositive}, сумма отр. = {resulNegative}");

// Задача: 32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] mass = new int[4];
// int massSize = mass.Length;
// for (int i = 0; i < massSize; i++)
// {
//    mass[i] = new Random().Next(-10, 11);
// }
// Console.Write($"[ {String.Join("; ", mass)} ]");
// for (int j = 0; j < massSize; j++)
// {
//     mass[j] = mass[j]*-1; // mass[j] = -mass[j]; mass[j] *= (-1);
// }
// Console.Write($"Результат: [ {String.Join("; ", mass)} ]");

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] mass = new int[4];
// int massSize = mass.Length;
// for (int i = 0; i < massSize; i++)
// {
//    mass[i] = new Random().Next(10);
// }
// Console.Write($"[ {String.Join("; ", mass)} ]");
// bool find = false;
// for (int j = 0; j < massSize; j++)
// {
//    if (mass[j] == number) 
//    {
//    find = true;
//    break;
//    }
// }
// if (find) Console.WriteLine($" число присутствует");
// else Console.WriteLine($" Числа нет");

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] mass = new int[10];
// int massSize = mass.Length;
// for (int i = 0; i < massSize; i++)
// {
//   mass[i] = new Random().Next(123);
// }
// Console.Write($"[ {String.Join("; ", mass)} ]");
// int count = 0;
// for (int j = 0; j < massSize; j++)
// {
//     if (mass[j] >= 10 && mass[j] < 100) count ++;
   
// }
// Console.Write($"-> {count} ");

// Домашняя работа к 5 семинару

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] mass = new int[5];
// int massSize = mass.Length;
// for (int i = 0; i < massSize; i++)
// {
//     mass[i] = new Random().Next(100, 1000);
//  }
//  Console.Write($"[ {String.Join("; ", mass)} ]");
//  int count = 0;
//  for (int j = 0; j < massSize; j++)
//  {
//    if (mass[j] % 2 == 0) count ++;
// }
// Console.Write($"Результат: {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] mass = new int[5];
// int massSize = mass.Length;
// for (int i = 0; i < massSize; i++)
// {
//     mass[i] = new Random().Next(-10, 100);
//  }
//  Console.Write($"[ {String.Join("; ", mass)} ]");
//  int summa = 0;
//  for (int j = 0; j < massSize; j++)
//  {
//    if (j % 2 != 0) summa =+ mass[j];
// }

// Console.Write($" Результат: {mass[1] + summa}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] mass = new double[5];
// int massSize = mass.Length;
// for (int i = 0; i < massSize; i++)
// {
//     mass[i] = new Random().NextDouble() * 100;
//  }
//  Console.Write($"[ {String.Join("; ", mass)} ] ");
//  double maximum = 0;
//  double minimum = mass[0];
//  double result = 0;
//  for (int j = 0; j < massSize; j++)
//  {
//    if (mass[j] > maximum) maximum = mass[j];
// };

// for (int k = 1; k < massSize; k++)
// {
//    if (mass[k] < minimum) minimum = mass[k];
// }
// result = maximum - minimum;

// Console.Write($"Максимум - {Math.Round(maximum,0)}, Минимум - {Math.Round(minimum,0)} Результат: {Math.Round(result,0)}");

// Классная работа. 6 семинар

// Задача 39
// int size = 6;
// int[] array = new int[size];
// for (int i = 0; i < array.Length; i++)
// {
//    array[i] = new Random().Next(11);
// }
//  Console.WriteLine($"Array: [ {String.Join("; ", array)}]");
//  int[] resultArray = new int[size];
//  int lastIndex = size - 1;

// for (int i = 0; i < size; i++)
// {
//    resultArray[i] = array[lastIndex - i];
// }
// Console.WriteLine($"Reverge array: [ {String.Join("; ", resultArray)}]");

// Задача 40

// Console.Write("Введите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число c: ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a+b>c && c+a>b && c+b>a)
// {
//    Console.WriteLine($"Данный треугольник может быть");
// }
// else  Console.WriteLine($"Данного треугольника не может быть");

// Задача 44

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// array[0] = 0;
// array[1] = 1;

// for (int i = 2; i < N; i++)
// {
//    array[i] = array[i-2] + array[i-1];
// }
// Console.WriteLine($"Reverge array: [ {String.Join("; ", array)}]");

// Второе решение

// int N = 10;

// int firstElement = 0;
// int secondElement = 1;

// Console.WriteLine(firstElement);
// Console.WriteLine(secondElement);

// for (int i = 3; i <= N; i++)
// {
//    int nextElement = firstElement + secondElement;
//    Console.WriteLine(nextElement);
//    firstElement = secondElement;
//    secondElement = nextElement;
// }

// Задача 45

// int size = 6;
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
//    array[i] = new Random().Next(11);
// }
//  Console.WriteLine($"Array: [ {String.Join("; ", array)}]");
//  int[] copyArray = new int[size];
// for (int i = 0; i < size; i++)
// {
//    copyArray[i] = array[i];
// }
// Console.WriteLine($"Copy array: [ {String.Join("; ", copyArray)}]");

// Домашнее задание к семинару 6

// Задача 41

//  Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[M];
// int count = 0;
// for (int i = 0; i < M; i++)
// {
//    array[i] = new Random().Next(-10, 11);
//    if (array[i] > 0) count++;
// }
// Console.WriteLine($"Количество положительных чисел в массиве [{String.Join("; ", array)}] = {count}");

// Задача 43 

// double b1 = 2;
// double k1 = 5;

// double b2 = 4;
// double k2 = 9;

// double variableX = (b1 - b2) / (k2 - k1);
// Console.WriteLine(variableX);
// double variableY = k1 * variableX + b1;
// Console.WriteLine(variableY);

// Console.WriteLine($"Точка пересечения имеет координаты [{Math.Round (variableX, 1)}; {Math.Round (variableY, 1)}]");

// k1 = k1*x + b1
// 5 = 5*x + 2
// 5x = 3
// X 3/5

// k1*x + b1 = k2*x + b2
// k1*x - k1 * x + b1 = k2*x + b2 - k1*x
// b1 = k2*x + b2 - k1*x
// b1 = (k2-k1)*x + b2
// x = (b1 - b2) / (k2 + k1)

// y = k1*x + b1
// y = k2*x + b2
// y = 5x + 2
// y = 9x + 4
// 5x-5x + 2 = 9x +4-5x
// 2 = 4x+4
// 4x +4-4 = 2-4
// 4x = -2
// x = -2/4
// x = -0,5
// y = 5*-0.5 + 2 = -0.5


// Классная работа 7 семинар.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// // m - строчки, n - столбцы
// int[,] GetArray(int m, int n)
// {
//    int[,] matrix = new int[m,n];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         matrix[i,j] = new Random().Next(11); 
//       }
//    }
//    return matrix;
// }
// int [,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//    for (int i = 0; i < inputMatrix.GetLength(0); i++)
//    {
//       for (int m = 0; m < inputMatrix.GetLength(1); m++)
//       {
//          Console.Write(inputMatrix[i,m] + "\t");
//       }
//       Console.WriteLine();
//    }
// }

// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// // m - строчки, n - столбцы
// int[,] GetArray(int m, int n)
// {
//    int[,] matrix = new int[m,n];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         matrix[i,j] = i+j; 
//       }
//    }
//    return matrix;
// }
// int [,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//    for (int i = 0; i < inputMatrix.GetLength(0); i++)
//    {
//       for (int m = 0; m < inputMatrix.GetLength(1); m++)
//       {
//          Console.Write(inputMatrix[i,m] + "\t");
//       }
//       Console.WriteLine();
//    }
// }

// Задача 49
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// // m - строчки, n - столбцы
// int[,] GetArray(int m, int n)
// {
//    int[,] matrix = new int[m,n];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         matrix[i,j] = new Random().Next(11); 
//       }
//    }
//    return matrix;
// }
// int [,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//    for (int i = 0; i < inputMatrix.GetLength(0); i++)
//    {
//       for (int m = 0; m < inputMatrix.GetLength(1); m++)
//       {
//          Console.Write(inputMatrix[i,m] + "\t");
//       }
//       Console.WriteLine();
//    }
// }

// int[,] ReplaceBySquare(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          if(i%2 == 0 && j%2 == 0) matrix[i, j] = Convert.ToInt32(Math.Pow(matrix[i, j], 2));
//       }
//    }
//    return matrix;
// }
// ReplaceBySquare(resultMatrix);
// Console.WriteLine();
// PrintArray(resultMatrix);

// Задача 51. Найти сумму элементов главной диагонали.
// например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] GetArray(int m, int n)
// {
//    int[,] matrix = new int[m,n];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         matrix[i,j] = new Random().Next(11); 
//       }
//    }
//    return matrix;
// }
// int [,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//    for (int i = 0; i < inputMatrix.GetLength(0); i++)
//    {
//       for (int m = 0; m < inputMatrix.GetLength(1); m++)
//       {
//          Console.Write(inputMatrix[i,m] + "\t");
//       }
//       Console.WriteLine();
//    }
// }
// int sum = 0;
// for (int i = 0; i < resultMatrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < resultMatrix.GetLength(1); j++)
//       {
//         if (i==j) sum +=  resultMatrix[i,j];
//       }
//    }
//    Console.WriteLine("Сумма элементов главной диагонали равна = " + sum);

// Домашняя работа по 7 семинару.

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] GetArray(int m, int n)
// {
//    double[,] matrix = new double[m,n];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         matrix[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10; 
//       }
//    }
//    return matrix;
// }
// double [,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(double[,] inputMatrix)
// {
//    for (int i = 0; i < inputMatrix.GetLength(0); i++)
//    {
//       for (int m = 0; m < inputMatrix.GetLength(1); m++)
//       {
//          Console.Write(inputMatrix[i,m] + "\t");
//       }
//       Console.WriteLine();
//    }
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите искомую строчку: ");
// int findArow = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите искомый столбец: ");
// int findAcolumn = Convert.ToInt32(Console.ReadLine());

// int[,] GetArray(int m, int n)
// {
//    int[,] matrix = new int[m,n];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         matrix[i,j] = new Random().Next(11);
//       }
//    }
//    return matrix;
// }
// if (findArow > rows || findAcolumn > columns) Console.WriteLine($"{findArow}{findAcolumn} -> такого числа в массиве нет"); 
// int [,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//    for (int i = 0; i < inputMatrix.GetLength(0); i++)
//    {
//       for (int m = 0; m < inputMatrix.GetLength(1); m++)
//       {
//          Console.Write(inputMatrix[i,m] + "\t");
//       }
//       Console.WriteLine();
//    }
// }

// int[,] findArray(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          if(findArow == i && findAcolumn-1 == j)  Console.WriteLine($"Искомое число -{matrix[i,j]}");
//       }
//    }
//    return matrix;
// }
// Console.WriteLine();
// findArray(resultMatrix);
// Console.WriteLine();
// PrintArray(resultMatrix);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] GetArray(int m, int n)
// {
//    int[,] matrix = new int[m,n];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         matrix[i,j] = new Random().Next(11); 
//       }
//    }
//    return matrix;
// }
// int [,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//    for (int i = 0; i < inputMatrix.GetLength(0); i++)
//    {
//       for (int m = 0; m < inputMatrix.GetLength(1); m++)
//       {
//          Console.Write(inputMatrix[i,m] + "\t");
//       }
//       Console.WriteLine();
//    }
// }

// double averageValue1 = 0;
// double averageValue2 = 0;
// double averageValue3 = 0;
// double averageValue4 = 0;
// for (int i = 0; i < resultMatrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < resultMatrix.GetLength(1); j++)
//       {
//         if (j==0) averageValue1 +=  resultMatrix[i,j];
//         if (j==1) averageValue2 +=  resultMatrix[i,j];
//         if (j==2) averageValue3 +=  resultMatrix[i,j];
//         if (j==3) averageValue4 +=  resultMatrix[i,j];
//       }
//    }
//    Console.WriteLine($"Среднее арифметическое столбца 1 = {Math.Round(averageValue1 / rows,1)}");
//    Console.WriteLine($"Среднее арифметическое столбца 2 = {Math.Round(averageValue2 / rows,1)}");
//    Console.WriteLine($"Среднее арифметическое столбца 3 = {Math.Round(averageValue3 / rows,1)}");
//    Console.WriteLine($"Среднее арифметическое столбца 4 = {Math.Round(averageValue4 / rows,1)}");

//Классная работа по семинару 8.

// int rows = Convert.ToInt32(Console.ReadLine());

// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] GetArray(int m, int n)
// {
//    int[,] matrix = new int[m, n];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          matrix[i, j] = new Random().Next(11);
//       }
//    }
//    return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          Console.Write(matrix[i,j] + "\t");
//       }
//    Console.WriteLine(); }
// }

// Метод замены строк

// void ChangeRows(int [,] inputMatrix)
// {
//    int indexLastRow = inputMatrix.GetLength(0) - 1;
//    for (int i = 0; i < inputMatrix.GetLength(1); i++)
//    {
//       int temp = inputMatrix[0, i];
//       inputMatrix[0, i] = inputMatrix[indexLastRow, i];
//       inputMatrix[indexLastRow, i] = temp;
//    }
// }

// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// Console.WriteLine("Result: ");
// ChangeRows(resultMatrix);
// PrintArray(resultMatrix);

// Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int rows = Convert.ToInt32(Console.ReadLine());

// int columns = Convert.ToInt32(Console.ReadLine());

// if (rows != columns)
// {
// Console.WriteLine("Заменить элементы нельзя");
// return;
// }

// int[,] GetArray(int m, int n)
// {
//    int[,] matrix = new int[m, n];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          matrix[i, j] = new Random().Next(11);
//       }
//    }
//    return matrix;
// }
// void PrintArray(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          Console.Write(matrix[i,j] + "\t");
//       }
//    Console.WriteLine(); }
// }

// int[,] ReplaceRowColums(int[,] replacableMatrix)
// {
//    int[,] result = new int[replacableMatrix.GetLength(0), replacableMatrix.GetLength(1)];
//    for (int i = 0; i < result.GetLength(0); i++)
//    {
//       for (int j = 0; j < replacableMatrix.GetLength(1); j++)
//       {
//          result[i, j] = replacableMatrix[j, i];
//       }
//    } return result;
// }
// int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// Console.WriteLine("Result: ");
// PrintArray(ReplaceRowColums(resultMatrix));

// Задача 59
// int rows = 3;
// int columns = 3;

// int[,] matrix = new int[rows, columns];
// int minElement = int.MaxValue;
// int indexMinRows = 0; // строчка
// int indexMinColumns = 0; // столбец с мин элементом

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = new Random().Next(11); // [0;10]
// Console.Write(matrix[i, j] + "\t");
// if (minElement > matrix[i, j]) // 5 > 0, min = 0
// {
// indexMinColumns = j;
// indexMinRows = i;
// minElement = matrix[i,j];
// }
// }
// Console.WriteLine();
// }
// System.Console.WriteLine("Result: ");
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// if (indexMinRows != i)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// if (indexMinColumns != j)
// {
// Console.Write(matrix[i, j] + "\t");
// }
// }
// Console.WriteLine();
// }
// }

// Домашняя работа к 8 семинару.
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int rows = 4;
// int columns = 3;
// int[,] matrix = new int[rows, columns];

// void GetArray(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          matrix[i, j] = new Random().Next(11);
//       }
//    }
// }
// void sortingNumber(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// for (int k = 0; k < matrix.GetLength(1) - 1; k++)
// {
// if (matrix[i,k] < matrix[i, k+1]) 
// {
// int minNumber = matrix[i, k+1];
// matrix[i, k+1] = matrix[i,k];
// matrix[i,k] = minNumber;
// }
// }
// }
// }
// }
// void PrintArray(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          Console.Write(matrix[i,j] + "\t");
//       }
//    Console.WriteLine();
//    }
// }
// GetArray(matrix);
// PrintArray(matrix);
// Console.WriteLine("Result: ");
// sortingNumber(matrix);
// PrintArray(matrix);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] GetArray(int m, int n)
// {
//    int[,] matrix = new int[m,n];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         matrix[i,j] = new Random().Next(11); 
//       }
//    }
//    return matrix;
// }
// int [,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);
// void PrintArray(int[,] inputMatrix)
// {
//    for (int i = 0; i < inputMatrix.GetLength(0); i++)
//    {
//       for (int m = 0; m < inputMatrix.GetLength(1); m++)
//       {
//          Console.Write(inputMatrix[i,m] + "\t");
//       }
//       Console.WriteLine();
//    }
// }
// int [,] sumMatrix = GetArray(rows, columns);
// sumMinRows(sumMatrix);
// void sumMinRows (int[,] matrix)
// {  int minRow = 0;
//    int sumRow = 0;
//    int minSumRow = 0;
//    for (int k = 0; k < matrix.GetLength(0); k++)
// {
//    minRow += matrix[0, k];
// }
// for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         sumRow += matrix[i,j];
//         if (sumRow < minRow)
//         {
//          minRow = sumRow;
//          minSumRow = i;
//         }
//       sumRow = 0;
//       }
//    }
//    Console.WriteLine($"Номер строки с наименьшей суммой элементов - {minSumRow + 1}");
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Write("Введите первое число: ");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] GetArray(int m, int n)
// {
//    int[,] matrix = new int[m, n];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          matrix[i, j] = new Random().Next(10);
//       }
//    }
//    return matrix;
// }

// void PrintArray(int[,] matrix)
// {
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//       for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//          if (j % 2==0) 
//          Console.Write(matrix[i,j] + " ");
//          else Console.Write(matrix[i,j] + "\t");
//       }
//    Console.WriteLine(); }

//    Console.WriteLine("Result: ");
//    Console.WriteLine($"{matrix[0,0] * matrix[0,2]} | {matrix[0,1] * matrix[0,3]} ");
//    Console.WriteLine($"{matrix[1,0] * matrix[1,2]} | {matrix[1,1] * matrix[1,3]} ");
// }
//  int[,] resultMatrix = GetArray(rows, columns);
// PrintArray(resultMatrix);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//    int k = 4;
//    int[,] matrix = new int[k, k];
//    int temp = 1;
//    int i = 0;
//    int j = 0;
//    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
//    {
//       matrix[i,j] = temp;
//       temp ++;
//       if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
//       {
//         j ++;
//       }
//       else if (i < j && j + i >= matrix.GetLength(0) - 1)
//       {
//          i ++;
//       }
//       else if (i >= j && i + j > matrix.GetLength(1) - 1)
//       {
//          j--;
//       }
//       else i--;
//    }


// PrintArray(matrix);
// void PrintArray(int[,] inputMatrix)
// {
//    for (int i = 0; i < inputMatrix.GetLength(0); i++)
//    {
//       for (int m = 0; m < inputMatrix.GetLength(1); m++)
//       {
//          Console.Write(inputMatrix[i,m] + "\t");
//       }
//       Console.WriteLine();
//    }
// }

// Классная работа 9 семинар

// int Factorial(int n)
// {
//    // Базовый случай - случай выхода из рекурсии
//    if(n==1) return 1; // Константа
//    // Рекурсивный случай - задание самой рекурсии (вызова функции)
//    return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(5));

// Задача 63

// int N = Convert.ToInt32(Console.ReadLine());
// //start = 1, откуда начинаем печать чисел; end - N, конец нашей последовательности
// string PrintNumbers(int start, int end)
// {
//    // Базовый случай
//    if (start == end) return start.ToString(); // N = 5; start == 5; "5"
//    //Рекурсивный случай
//    return (start + ", " + PrintNumbers(start +1, end));
// }
// Console.WriteLine($"Чисоа от 1 до {N}: {PrintNumbers(1, N)}");

// Задача 67
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
//    // Базовый случай
//    if (num == 00) return 0; // 
//    // Рекурсивный случай
//    return (num % 10 + SumNumbers(num / 10));
// }
// Console.WriteLine($"Сумма цифр в числе {number} = {SumNumbers(number)}");

// Задача 69

// int number = Convert.ToInt32(Console.ReadLine());
// int degree = Convert.ToInt32(Console.ReadLine());

// int Power (int number, int power)
// {
//    // Базовый случай - случай с заранее известным результатом
//    if (power == 0) return 1;
//    if (power == 1) return number;
//    // Рекурсивный случай - рекурсия
//    return (number * Power(number, power -1));
// }
// Console.WriteLine($"Число {number} в степени {degree} - {Power(number, degree)}");

// Домашняя работа к 9 семинару 
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int M = Convert.ToInt32(Console.ReadLine());
// int N = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int start, int end)
// {
//    // Базовый случай
//    if (start > end) return 0; // 
//    // Рекурсивный случай
//    return (start + SumNumbers(start +1, end));
// }
// Console.WriteLine($"Сумма цифр от {M} до {N} = {SumNumbers(M, N)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

// int m = 2;
// int n = 3;

// int PowerNumbers(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if ((m != 0) && (n==0))
//   return PowerNumbers(m-1, 1);
//    else return PowerNumbers (m-1, (PowerNumbers(m, n-1)));
// }
// Console.WriteLine($" m = 2, n = 3 -> A(m,n) = {PowerNumbers(m, n)}");