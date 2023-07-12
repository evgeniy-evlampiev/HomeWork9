// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите число: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{getSum(M, N)}");

int getSum(int start, int end){
    int sum = 0;
    if (start == end) return sum+start;
    return(start + getSum(start+1, end));

}
