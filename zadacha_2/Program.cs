// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000) 
// 645 -> 5 
// 78 -> третьей цифры нет 
// 32679 -> 6 
 
Console.WriteLine("введите любое число до 100000"); 
int number = int.Parse(Console.ReadLine()!); 
int thirdnumb = 0;
int thirdnumb1 = 0;
int thirdnumb2 = 0;

if(number <100) 
{ 
    Console.WriteLine("третьей цифры нет"); 
}

if(number>100 && number< 1000) 
{
    thirdnumb = number % 10;
    Console.WriteLine($"третья цифра числа = {thirdnumb}"); 
}
if(number>1000 && number<10000)
{
    thirdnumb1 = (number % 100)/10;
    Console.WriteLine($"третья цифра числа = {thirdnumb1}");
}
if(number>10000 && number<100000)
{
    thirdnumb2 = (number % 1000)/100;
    Console.WriteLine($"третья цифра числа = {thirdnumb2}");
}

