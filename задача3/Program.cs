// программа, которая принимает на вход число N
// и выдает произведение чисел от 1 до N - Факториал

int Factorial(int N)
{
    int result = 1;
    for (int i = 1; i <= N; i++)
 {
    result *= i;  // или result += i
 }
 return result;
}
 //int sum1;
 //sum1 = int = Factorial(int N)
 //System.Console.WriteLine(sum1);

System.Console.WriteLine(Factorial(1));


//Console.WriteLine($"Произведение чисел от 1 до {A} = {sum}");


