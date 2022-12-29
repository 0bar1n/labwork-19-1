using System;

class Program
{
	static void Main()
	{
		string a1 = "Error: division by zero!"; //задание текста ошибки 1
		string a2 = "Error in input!"; //задание текста ошибки 2
		int N = Convert.ToInt32(Console.ReadLine()); //ввод числа с консоли
		if (N == 0) //выполнить, если введен 0
		{
			Console.WriteLine($"{a1}");//вывод ошибки
		} 
		else //другой исход
		{
			Console.WriteLine($"{a2}");// вывод ошибки
		}		
		Console.ReadLine();//прогорамма ждет нажатия клавиши для завершения работы
	}
}