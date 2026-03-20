System.Console.Write("Введите число1: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.Write("Введите число2: ");
int num2 = int.Parse(Console.ReadLine());
System.Console.Write("Введите операцию: ");
string op = Console.ReadLine();

switch (op)
{
    case "+": System.Console.WriteLine(Sum(num1, num2));break;
    case "-": System.Console.WriteLine(Sub(num1, num2));break;
    case "*": System.Console.WriteLine(Mul(num1, num2));break;
    case "/": System.Console.WriteLine(Div(num1, num2));break;
}
static int Sum(int a, int b)
{
    int res = a + b;
    return res;
}
static int Sub(int a, int b)
{
    int res = a - b;
    return res;
}
static int Div(int a, int b)
{
    int res = a / b;
    return res;
}
static int Mul(int a, int b)
{
    int res = a * b;
    return res;
}