Console.Clear();
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

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
