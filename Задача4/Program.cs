// Программа которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

int [] array = new int [8];

for (int i = 0; i < array.Length; i++)  // Задаем значание
{
    array[i] = new Random().Next(0,2);
}
for (int i = 0; i < array.Length; i++)  // Выводим значение
{
    System.Console.Write($"{array[i]} ");
}


    


