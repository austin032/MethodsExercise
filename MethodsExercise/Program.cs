namespace MethodsExercise
{
    public class Program
    {
        public static void MadLib()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite sport?");
            string sport = Console.ReadLine();
            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();
            Console.WriteLine("What is your favorite tv show?");
            string tv = Console.ReadLine();
            
            Console.WriteLine($"Over the weekend {name} was out playing {sport}, after nine holes he stopped and grabbed a {food}. When he was finished playing he winded down by watching the {tv}.");
        }
        static void Main(string[] args)
        {
            MadLib();
        }
    }
}
