// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. //0, 7, 8, -2, -2 -> 2  //-1, -7, 567, 89, 223-> 3
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
