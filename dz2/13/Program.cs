//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

 Console.WriteLine ("Введите любое число: ");
 int number = int.Parse (Console.ReadLine()!);
 
   int ThirdDigit(int number)
        {
            if (number >= 100)
           
            {
                while (number > 999)
                {
                    number = number / 10;
                }
                    int result = number % 10;
                  
                    Console.WriteLine ("Третья цифра числа: " + result);
            }
            
                else 
                    {
                        Console.WriteLine ("третьей цифры нет");
                    }
             
           return number;
        }
    
ThirdDigit (number);
