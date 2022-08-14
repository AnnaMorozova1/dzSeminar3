//  Напишите программу, которая принимает на вход число (N) 
//  и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine());
double stepen = 3;
for (double index = 0; index <= number; index++)
Console.WriteLine(Math.Pow(index, stepen));
    

