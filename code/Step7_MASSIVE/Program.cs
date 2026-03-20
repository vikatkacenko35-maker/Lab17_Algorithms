int[] marks = new int[] { 5, 4, 3, 2, 4 };
foreach (int i in marks)
{
    System.Console.WriteLine($"Оценка: {i}");
}
int maxim = 0;
foreach (int item in marks)
{
    if (item > maxim)
    {
        maxim = item;
    }
}
System.Console.WriteLine(maxim);