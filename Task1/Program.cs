internal class Program
{
    private static void Main(string[] args)
    {
        //Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
        //Использовать рекурсию, не использовать циклы.

        int m = 0;
        int n = 0;

        // Запрашиваем у пользователя значения M и N с проверкой на правильность ввода
        do
        {
            Console.Write("Введите значение M: ");
        } while (!int.TryParse(Console.ReadLine(), out m) || m <= 0);

        do
        {
            Console.Write("Введите значение N (больше либо равно M): ");
        } while (!int.TryParse(Console.ReadLine(), out n) || n < m);
    }
}