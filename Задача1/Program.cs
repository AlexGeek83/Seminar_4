// программа которая принимает на вход число А и 
// выдает сумму чисел от 1 до А


int A = 5;
int sum = 0;
for (int i = 0; i <= A; i++)
{
    sum = sum + i;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");


//========================================
//    2-й Вариант

// int SumToA(int A)
// {
//    int result = 0;
//    for (int i = 0; i <= A; i++)
// {
//    result = result + i;  // или result += i
// }
// return result;
// }
// int sum1;
// sum1 = int = SumToA(int A)
// System.Console.WriteLine(sum1);
// или вместо 3 верхних строк одну и более такую - System.Console.WriteLine(SumToA(4));
// System.Console.WriteLine(SumToA(8));
// и т.д.


