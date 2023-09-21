namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess the correct number!");
            Console.WriteLine("What is the upper limit for the range of the number?");

            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);

            Console.WriteLine("Input your guess:");

            var guess = int.Parse(Console.ReadLine());

            if(guess > number)
            {
                Console.WriteLine("Your guess is to high! Sorry.");
            }
            else if(guess < number)
            {
                Console.WriteLine("Your guess is to low! Sorry.");
            }
            else
            {
                Console.WriteLine("You guessed it!!! Great job!");
            }
        }
    }
}
