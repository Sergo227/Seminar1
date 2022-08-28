
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

Console.Write("Введите число: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
string inputNumberText = Convert.ToString(inputNumber);

if (inputNumberText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + inputNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}