// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
// 6 -> да
//7  -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели" );
int number = int.Parse(Console.ReadLine()!);

if(number >= 1 && number <= 5)
{
Console.WriteLine("это будний день");
}
if(number >= 6 && number <= 7)
{
    Console.WriteLine("это выходной день");
}
if(number > 7 || number <= 0)
{
    Console.WriteLine("дня недели под такой цифрой не существует");
}