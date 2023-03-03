// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число >");

string inputValue1 = Console.ReadLine();
Console.WriteLine("Введите второе число >");
string inputValue2 = Console.ReadLine();

while (true) 
{int value1 = Convert.ToInt32(inputValue1);
int value2 = Convert.ToInt32(inputValue2);

if (value1==value2)
{
    Console.WriteLine($"число {value1} равно числу {value2}");
    break;
}

if (value1 > value2)
{
    Console.WriteLine($"число {value1} больше числа {value2}");
    break;
}

else
{
    Console.WriteLine($"число {value1} меньше числа {value2}");
    break;
}
}