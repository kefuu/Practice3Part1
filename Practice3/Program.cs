using System.Numerics;
using System.Threading.Tasks;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1
            int start = 1;
            int end = 5;

            try
            {
                BigInteger product = task1.CalculateProduct(start, end);
                Console.WriteLine($"Добуток чисел з {start} до {end} це {product}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            //task 2
            int number = 8;
            bool isFibonacci = task2.IsFibonacci(number);

            if (isFibonacci)
            {
                Console.WriteLine($"{number} є числом Фібоначчі.");
            }
            else
            {
                Console.WriteLine($"{number} не є числом Фібоначчі.");
            }

            //task 3
            int[] array = new int[] { 5, 2, 8, 1, 3 };
            Console.Write("Оригінальний масив: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("Введіть порядок сортування (A - за зростанням, D - за спаданням): ");
            char sortOrder = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (sortOrder != 'A' && sortOrder != 'D')
            {
                Console.WriteLine("Неправильний порядок сортування. Будь ласка, введіть 'A' або 'D'.");
                return;
            }

            task3.SortArray(array, sortOrder == 'A');

            Console.Write("Відсортований масив: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}