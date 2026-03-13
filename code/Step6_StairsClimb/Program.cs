System.Console.WriteLine("подъем по лестнице");
System.Console.Write("На какой этаж вам надо?: ");
int targerFloor = Convert.ToInt32(Console.ReadLine());
int currentFloor = 1;
System.Console.WriteLine(" Начинаем подъем");
while (currentFloor < targerFloor)
{
    currentFloor++;
    System.Console.WriteLine($"Поднялись на {currentFloor} этаж");

}
System.Console.WriteLine($"Вы достигли {targerFloor}");
System.Console.WriteLine("end");