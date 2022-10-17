namespace HomeWorkFunction3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadInt();
        }

        static int ReadInt()
        {
            int number = 0;
            bool isProgramOn = true;

            while (isProgramOn)
            {
                Console.WriteLine("Введите значение: ");
                string? userInput = Console.ReadLine();
                bool haveResult = int.TryParse(userInput, out number);

                if (haveResult == true)
                {
                    Console.WriteLine("Введенное число: " + number);
                    return number;
                }
                else
                {
                    Console.WriteLine("Введенная строка: " + userInput);
                }
            }
            return number;

        }

    }

}