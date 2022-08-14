// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите 5-значное число: ");
string number = Console.ReadLine();

bool task = true;
   for (int i = 0; i < (number.Length - 1) / 2; i++)
    if (number[i] != number[number.Length - i - 1])
         task = false;
 int num = Convert.ToInt32(number);
 if (num>9999 && num<100000)
 {
    if (task)
    {
        Console.WriteLine("Палиндром");
    }
    else 
    {
        Console.WriteLine("Не палиндром");
     }
 }

else 
{
    Console.WriteLine("Число не 5-значное!");
}
