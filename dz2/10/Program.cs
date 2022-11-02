// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int GenerateRandomNum()
{
    return new Random ().Next(100, 1000);
}

int SaveSecondDigit (int randomnumber)
{
     int firstNum = randomnumber / 10;
     return firstNum % 10;
}
int randomnumber = GenerateRandomNum();
     Console.WriteLine(randomnumber);
     Console.WriteLine(SaveSecondDigit(randomnumber));
