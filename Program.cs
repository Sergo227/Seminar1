
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

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов: ");
for (int i = 1; i <= N; i++) Console.WriteLine(Math.Pow(i,3));