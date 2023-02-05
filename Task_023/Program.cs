// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintCubes(number);

void PrintCubes(int a)
{
    if (number > 1)
    {
        for (int i = 1; i <= number; i++)
            System.Console.WriteLine(Math.Pow(i, 3));
    }
    else
        System.Console.WriteLine($"Ошибка! {number}<1");
}
