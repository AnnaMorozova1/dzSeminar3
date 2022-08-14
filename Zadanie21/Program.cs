//  Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

        
Double x1=0;
Double x2=0;
Double y1=0;
Double y2=0;
Double z1=0;
Double z2=0;

Double result;

Console.Write("x1=");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("y1=");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("z1=");
z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("x2=");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("y2=");
y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("z2=");
z2 = Convert.ToDouble(Console.ReadLine());
           
result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
Console.WriteLine("result:" + Math.Round(result, 2));

        



