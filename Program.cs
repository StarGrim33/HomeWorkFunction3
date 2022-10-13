namespace HomeWorkFunction3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToConvert();
        }

        static void ToConvert()
        {
            bool isProgramOn = true;

            while (isProgramOn)
            {
                Console.WriteLine("Введите строку: ");
                string? userInput = Console.ReadLine();
                bool result = int.TryParse(userInput, out int number);

                if (result == true)
                {
                    Console.WriteLine("Successful: " + number);
                    isProgramOn = false;
                }
                else
                    Console.WriteLine("Try again");
            }

        }

    }
}