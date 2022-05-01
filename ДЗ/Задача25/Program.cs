// Напишите (функцию) цикл,мкоторый принимает на вход два числа (А и В)
// и возводит А в натуральную степень В.
// 3,5 -> 243(3*)
// 2,4 -> 16

Console.Write("Введите число А: ");
string enterNumA = Console.ReadLine();
int numA = Convert.ToInt32(enterNumA);

Console.Write("Введите число В: ");
string enterNumB = Console.ReadLine();
int numB = Convert.ToInt32(enterNumB);

// int numA = 2;  // число
// int numB = 4;  //степень
int result = numA;  


for (int i = 1; i < numB; i++)
{
    result = result * numA;
}
System.Console.WriteLine($"Число {numA} в натуральной степени {numB} равно {result}");

