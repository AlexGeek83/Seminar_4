// Напишите (функцию) программу, которая принимает на вход число и выдает сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
string enterNumA = Console.ReadLine();
int numA = Convert.ToInt32(enterNumA);
int SumA = 0;
// if(numA < 0)
// numA = - numA;

while (numA > 0)
{
    int numB = numA % 10;
    SumA += numB;
    numA /= 10;
}
System.Console.Write($"Сумма цифр введённого числа  равна {SumA}");


