/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

using static Common.Helper;

int n = UserInputint("enter N: ");
int[] array = new int[n];
Recursy(array, n);
PrintArray(array);

void Recursy(int[] array, int i)
{
	if (i == 0)
	{
		return;
	}
	array[array.Length - i] = i;
	Recursy(array, --i);
}