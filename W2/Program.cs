/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

using static Common.Helper;

int n = UserInputint("enter N: ");
int m = UserInputint("enter M: ");
Console.WriteLine($"result = {GetSum(m, n)}");
int GetSum(int m, int n)
{
	if (m > n)
	{
		return 0;
	}
	int sum = m;
		return sum + GetSum(++m, n);
}