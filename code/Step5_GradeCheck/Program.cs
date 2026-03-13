System.Console.WriteLine("Определение оценки по баллам");
System.Console.WriteLine("Введите количестов баллов");
int score = Convert.ToInt32(Console.ReadLine());
string grade;
int numericgrade;

if (score >= 91 && score <= 100)
{
    grade = "A";
    numericgrade = 5;
}
else if (score >= 71 && score < 90)
{
    grade = "B";
    numericgrade = 4; 
}
else if (score >= 51 && score < 70)
{
    grade = "C";
    numericgrade = 3;
}
else if (score >= 0 && score < 50)
{
    grade = "D";
    numericgrade = 2; 
}
else
{
    grade = "Error";
    numericgrade = 0;
    System.Console.WriteLine("баллы должны быть от 0 до 100");
    return;
}

System.Console.WriteLine("Result:");
System.Console.WriteLine($"Баллы : {score}");
System.Console.WriteLine($"Оценка: {grade}({numericgrade})");