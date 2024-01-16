using System.Reflection.Metadata.Ecma335;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = 17 + 4;

            Console.WriteLine(sum);
            
                int c = 17;
                int d = 4;

                Console.WriteLine(c - d);
            
            
                int divided = 17 / 4;

                Console.WriteLine(divided);
            
            
                int a = 17;
                int b = 4;

                Console.WriteLine(a * b);
            
            int remainder = 17 % 4;
            Console.WriteLine(remainder);
            {
                Console.WriteLine("Enter the radius of the circle: ");

                double userInput = double.Parse(Console.ReadLine());

                Console.WriteLine(AreaOfCircle(userInput));
            }
        }

        public static double AreaOfCircle(double radius)
        {

            return Math.PI * Math.Pow(radius, 2);
        }

    }
}

