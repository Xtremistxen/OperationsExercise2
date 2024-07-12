namespace OperationsExercise2;

class Program
{
    static void Main(string[] args)
    {
        static void Main()
        {
            
            //This will display the result of 17 divided by 4 with the remainder
            int diviend = 17;
            int divisior = 4;
            int quotient = diviend / divisior;
            int remainder = diviend / divisior;
            
            Console.WriteLine($"{diviend} diviend by {divisior} is {quotient} remainder {remainder}");
            
            // Prompt User for input for the circle of the radius
            Console.Write("Enter the radius of the circle: ");
            double radius;

            // The input from the user and parse it to a double
            try
            {
                radius = double.Parse(Console.ReadLine());

                // Ensure the radius is non-negative
                if (radius < 0)
                {
                    Console.WriteLine("Radius cannot be negative.");
                    return;
                }

                // Call the AreaOfCircle method and store the result
                double area = AreaOfCircle(radius);

                // Display the result
                Console.WriteLine("The area of the circle with radius " + radius + " is " + area);
            
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
            }
            
                // Method to calculate the area of a circle
                static double AreaOfCircle(double radius)
                {
                    return Math.PI * Math.Pow(radius, 2);
                }
            }
        }
    }
