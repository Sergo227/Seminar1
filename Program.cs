
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

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    if (i % 2==0)
    {Console.Write(i + " ");}
} 
