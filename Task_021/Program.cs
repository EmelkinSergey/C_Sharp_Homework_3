// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координату X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

// Находим расстояние d между точками
double d = Math.Sqrt((Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)))
            +Math.Pow(z1-z2,2));

Console.WriteLine($"Расстояние между точками равно d={d:f5}");