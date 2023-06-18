// написать программу,  которая на вход принимает 3-ех значное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("введите трехзначное число  ");
int number = int.Parse(Console.ReadLine()!);
if(number>99 && number <1000)
{
    Console.WriteLine("число трехзначное");
}
else 
{
    Console.WriteLine("число не трехзначное");
}
int number1 = ( number/10 ) % 10;
if(number>99 && number <1000)
{
Console.WriteLine($"вторая цифра числа = {number1}");
}




