// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

int InputXYZ(string str)
{
    System.Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = InputXYZ("Введите координату первой точки x: ");
int y1 = InputXYZ("Введите координату первой точки y: ");
int z1 = InputXYZ("Введите координату первой точки z: ");

int x2 = InputXYZ("Введите координату второй точки x: ");
int y2 = InputXYZ("Введите координату второй точки y: ");
int z2 = InputXYZ("Введите координату второй точки z: ");

double distance = Math.Round(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)),3);
System.Console.WriteLine($"Расстояние между заданными точками: {distance}");