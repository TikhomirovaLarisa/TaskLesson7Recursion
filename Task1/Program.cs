internal class Program
{
    private static void Main(string[] args)
    {
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
    // Рекурсивная функция
    static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m + " ");
            PrintNaturalNumbers(m + 1, n); // Рекурсивный вызов
        }
    }
}