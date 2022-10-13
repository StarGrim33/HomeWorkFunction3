namespace HomeWorkFunction3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            bool isProgramOn = true;

            while (isProgramOn)
            {
                ReadInt(number);
            }

        }

        static int ReadInt(int number)
        {
            Console.WriteLine("Введите строку: ");
            string? userInput = Console.ReadLine();
            bool haveResult = int.TryParse(userInput, out number);

            if (haveResult == true)
            {
                Console.WriteLine("Successful: " + number);
                return number;
            }
            else
            {
                return 1;
            }

        }

    }

}