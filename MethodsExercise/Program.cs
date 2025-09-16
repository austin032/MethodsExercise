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

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            
            return sum;
        }
        
        static void Main(string[] args)
        {
            //MadLib();
            //Console.WriteLine(Add(4, 4));
            //Console.WriteLine(Subtract(6, 4));
            //Console.WriteLine(Multiply(5, 5));
            //Console.WriteLine(Divide(10, 2));
            Console.WriteLine(Sum(3, 3, 3, 3, 3, 3, 3, 3));
        }
    }
}
