int a = 5;
int b = 6;
int c = a + b;
Console.WriteLine(a + b); //Первая задача

Console.WriteLine();

if (c % 2 == 0)
{
    Console.WriteLine("Число Чётное");
}
else
{
    Console.WriteLine("Число НЕчётное");
}//вторая задача

Console.WriteLine();

if (a > b)
{
    Console.WriteLine(a > b);
} //третья задача 

Console.WriteLine();

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Таблица умножения на {i}:");

    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}//Четвертая задача

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine());

int sum = N * (N + 1) / 2;

Console.WriteLine($"Сумма чисел от 1 до {N} = {sum}");//пятая задача

Console.Write("Введите год: ");
int D = int.Parse(Console.ReadLine());
if (D % 4 == 0)
{
    Console.WriteLine($"Год {D} Високосный");
}
else
{
    Console.WriteLine($"Год {D} не Високосный");
}//Шестая задача
