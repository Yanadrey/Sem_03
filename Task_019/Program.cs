// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

System.Console.WriteLine("Введите пятизначное число: ");

string array = Console.ReadLine();
int number = Convert.ToInt32(array);

if (number >= 10000 && number < 100000)
{
    if (array[0] == array[4] && array[1] == array[3])
        System.Console.WriteLine("Введенное число является палиндромом");
    else
        System.Console.WriteLine("Введенное число не является палиндромом");
}
else
    System.Console.WriteLine("Ошибка! Необходимо ввести пятизначное число!");

