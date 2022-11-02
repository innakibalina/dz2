// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("1 - понедельник, 2 - вторник, 3 - среда, 4 - четверг, 5 - пятница, 6 - суббота, 7 - воскресенье");
Console.WriteLine("Введите цифру, обозначающую день недели:");
int  num = new Random ().Next(1, 8);
Console.WriteLine(num);
int day = num;
if (NumDay(day))
{
    Console.WriteLine("Это выходной");
}
    else{
        Console.WriteLine("Нет, это не выходной");
    }

bool NumDay(int num)
{
    return (day == 6 || day == 7);
}


