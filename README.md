# lesson_6
 ### // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
Результат: `0, 7, 8, -2, -2 -> 2 `
```csharp
int[] rnd_num(int A){
    try {
        int[] arr = new int[A];
        for (int i = 0; i < A; i++)
    {
        Console.WriteLine($"Введите число #{i+1} из {A}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }  
        return arr;
    }
    catch {Console.WriteLine("Это НЕ число!!!\n"); return rnd_num(A);}
}
void answer(int B){
    int[] arr = rnd_num(B); 
    int k = 0;
    foreach(int element in arr) if (element >0 ) k++;
    for (int i = 0; i < B - 1; ++i) Console.Write(arr[i] + ", ");
    Console.WriteLine(arr[B - 1] + " ->  " + k);
}
Console.WriteLine("Сколько раз вы будете вводить числа? ");
int B = Convert.ToInt32(Console.ReadLine());
answer(B);
```


### // Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Результат: `b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)`

```csharp
void cross_coordinates(double k1, double b1, double k2, double b2)
{
	double x = (b1-b2) / (k2-k1);
	double y = (k2*b1-k1*b2) / (k2-k1);
	if( k1 == k2 ) Console.Write("Заданные прямые не пересекаются!");
	else Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}

Console.WriteLine("Введите координату b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
cross_coordinates(k1,b1,k2,b2);
```


