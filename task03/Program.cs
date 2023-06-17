// Задача 23
// Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.Write("Введите любое целое число: ");
// первый способ цикл for
int num = int.Parse(Console.ReadLine());
Console.Write("Первый способ: ");
for (int i = 1; i <= num; i++) Console.Write($"{Math.Pow(i,3)} ");
Console.Write("\n");
// второй способ при помощи массива 
Console.Write("Второй способ: ");
int[] list1 = new int[num];
for (int i = 1; i <= num; i++ ) list1[i - 1] = i * i * i;
for (int i = 0; i < num; i++) Console.Write($"{list1[i]} ");
Console.Write("\n");
// второй модифицированный при помощи библиотеки Math
Console.Write("Третий способ: ");
double[] list2 = new double[num];
for (int i = 1; i <= num; i++) list2[i - 1] = Math.Pow(i, 3);
for (int i = 0; i < num; i++) Console.Write($"{list2[i]} ");