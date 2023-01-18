Console.Clear();
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int degree (int x, int y) {
    int f = x;
    for (int i = 1; i<Math.Abs(y); i++) {
    x=f*x;
}
return x;
}
Console.Write ("Введите число A: ");
int A = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write ("Введите число B: ");
int B = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Write ($"Число А в степени В: {degree(A,B)}.");
*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int summary (int x, int y) {
    int sum = 0;
    for (int i = 0; i<=y; i++) {
        if (x%10>0) {
        sum=sum+x%10;
        x=x/10;
      }
      else {
        sum=sum+x;
        }
}
return sum;
}
Console.Write ("Введите число: ");
int A = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int y=0;
int x=A;
for (int i = 0; i<=A; i++) {
        if (x/10>0) {
        y++;
        x=x/10;
      }
      }
Console.Write ($"Сумма цифр в числе: {summary(A, y)}.");
*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] GenerateArray(int length, int minNum, int maxNum)
{
    int[] arr = new int[length];
    for (int i=0;i<arr.Length;i++)
    {
        arr[i] = new Random().Next(minNum, maxNum + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i=0;i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int arr_len = 8;
Console.Write ("Введите число минимального значения числа массива: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число максимального значения числа массива: ");
int B = Convert.ToInt32(Console.ReadLine());
PrintArray(GenerateArray(arr_len, A, B));