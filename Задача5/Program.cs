// 4 метода!

// 1-й метод - ничего не принимает, ничео не возвращает, тупо вызвать когда нужно.

void Print()   //если ничего не принимает и ничего не возвращает, то скобки пустые
{
    Console.WriteLine("Функция выполнена!"); // либо return
}
Print();

//========================================================================

// 2- метод - принимает и возвращает

string Hello(string name)  //что принимает в круглых скобках, а возвращает "string" - название функции
{
    return "Пивет " + name;
}

string myName = "Алекс";
string helloName = Hello(myName);

// 3-й метод  - принимает значения и не возвращает т.е. void
void PrintArgument(double argument);
{
    System.Console.WriteLine(argument);
}
PrintArgument(123.1233);

// 4-й метод - не принимает и возвращает

int Return7()  // ничего не принимает
{
    return 7;
}
System.Console.WriteLine(Return7());

/*
ВозврТип Название (параметры)
{
    тело...
    return
}
*/

// пример: вывести все эл-ты массива, но до 0

void PrintArrayToZero(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] == 0)
        return;  // break - можно использовать внутри цикла
        System.Console.WriteLine(mas[i] + " ");
    }
}
int[] array = {1, 5, 7, 2, 8, 0, 1, 6, 2 };

PrintArrayToZero(array);


//  ищем максимум среди 2-х значений
// 1-й вариант
int max(int a, int b)
{
    if (a > b)
        return a;
    else
        return b;
}
System.Console.WriteLine(max(-1, 2));

// 2-й вариант
void PrintMax(int a, int b)
{
    if (a > b)
        System.Console.WriteLine(a);
    else
        System.Console.WriteLine(b);
}





