// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Lenght(int xA, int yA, int zA, int xB, int yB, int zB)
{
    double distance = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));
    return distance;
}

int GetInfo (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int coorA1 = GetInfo("Введите координату X точки А: ");
int coorA2 = GetInfo("Введите координату У точки А: ");
int coorA3 = GetInfo("Введите координату Z точки А: ");
int coorB1 = GetInfo("Введите координату X точки В: ");
int coorB2 = GetInfo("Введите координату У точки В: ");
int coorB3 = GetInfo("Введите координату Z точки B: ");

Console.WriteLine($"Расстояние между двумя точками в трёхмерном пространстве равно {Lenght(coorA1, coorA2, coorA3, coorB1, coorB2, coorB3)}");