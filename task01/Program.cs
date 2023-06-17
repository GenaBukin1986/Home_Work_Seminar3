// Задача 19
// Напишите программу, которая принимает на вход
// пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите целое пятизначное число: ");
int num = int.Parse(Console.ReadLine());
if (Convert.ToString(num).Length == 5) // Проверка может быть и такой if (num / 10000 > 0 && num / 10000 < 10)
{
// первый способ при помощи строки
Console.Write("Первый способ: ");
string num1 = Convert.ToString(num);
if (num1[0] == num1[4] && num1[1] == num1[3]) Console.WriteLine($"Число {num} является палиндромом");
else Console.WriteLine($"Число {num} не является палиндромом");
// второй способ при помощи математических действий
Console.Write("Второй способ: ");
int a = num / 10000;
int b = num /1000 % 10;
int c = num / 10 % 10;
int d = num % 10;
if (a == d && b == c) Console.WriteLine($"Число {num} является палиндромом");
else Console.WriteLine($"Число {num} не является палиндромом");
}else Console.Write("Вы ввели не пятизначное число!");