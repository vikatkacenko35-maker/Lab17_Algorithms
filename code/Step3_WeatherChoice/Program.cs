// See https://aka.ms/new-console-template for more information
Console.WriteLine("Choose clothes by weather");
System.Console.Write("Enter temp (C): ");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature >= 20)
{
    System.Console.WriteLine("Bring summer clothes");
}
else
{
    System.Console.WriteLine("Bring winter clothes");
}
System.Console.WriteLine("Have a nice day!");
