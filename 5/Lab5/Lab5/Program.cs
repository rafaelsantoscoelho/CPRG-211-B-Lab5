namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5.5);
            Console.WriteLine(c1.ToString());
            
            try
            {
                Circle c2 = new Circle(-12.3);
            }
            catch (InvalidRadiusException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Circle c3 = new Circle(0);
            }
            catch (InvalidRadiusException)
            {
            }
        }
    }
}