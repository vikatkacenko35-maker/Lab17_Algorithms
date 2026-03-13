System.Console.WriteLine("Таблица умножения");
System.Console.Write("введите число");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Таблица умножени для {number}");

for (int i = 1; i <= 10; i++)
{
    int result = number + i;
    System.Console.WriteLine($"{number} x {i} = {result}");
}
System.Console.WriteLine("end");