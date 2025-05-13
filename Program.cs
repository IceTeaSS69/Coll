int a = 5;
int b = 6;
int c = a + b;
if (c % 2 == 0)
{
    Console.WriteLine("Число Чётное");
}
else
{
    Console.WriteLine("Число НЕчётное");
}//вторая задача

Console.WriteLine(a + b); //Первая задача
if (a > b)
{
    Console.WriteLine(a > b);
} //третья задача 

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Таблица умножения на {i}:");

    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
}//Четвертая задача