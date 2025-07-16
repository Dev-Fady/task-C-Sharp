namespace task_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========Welcome in our voting system=========");

            Console.WriteLine("Please enter your name:");
            string? name = Console.ReadLine();

            Console.WriteLine("Please enter your age or your year of birth:");
            string? ageOrDate = Console.ReadLine();

            int age = default;

            if (int.TryParse(ageOrDate, out int number))
            {
                if (ageOrDate.Length <= 3)
                {
                    age = number;
                }
                else if (ageOrDate.Length == 4)
                {
                    int birthYear = number;
                    int currentYear = DateTime.Now.Year;
                    int calculatedAge = currentYear - birthYear;
                    age = calculatedAge;
                }
            }
            Console.WriteLine($"Hi Mr.{name} Your age is {age}");
            if (age >= 18)
            {
                Console.WriteLine("old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote!");
            }
        }
    }
}
