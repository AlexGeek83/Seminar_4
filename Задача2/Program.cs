// программа которая принимает на вход число и
// выдает количество цифр в числе

int Chislo(int num) //функция Chislo
 {
    int result = 0;
    //if (num < 0)  // проверка на отрицательность
    //     num = -num; // проверка на отрицательность
    if (num == 0)  // проверка если 0
        return 1;  // проверка если 0
    while (num != 0)
 {
     num /= 10;
     result++;  
 }
 return result;
 }
System.Console.WriteLine($"Количество цифр в числе {Chislo(0)}");




