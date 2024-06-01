namespace OOPs1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some colors
            Color redColor = new Color(255, 0, 0);
            Color greenColor = new Color(0, 255, 0, 128); 

            // Create some balls
            Ball ball1 = new Ball(10, redColor);
            Ball ball2 = new Ball(15, greenColor);

            // Throw the balls around
            ball1.Throw();
            ball1.Throw();
            ball2.Throw();

            // Pop ball1 and try to throw it again
            ball1.Pop();
            ball1.Throw();

            // Output the throw counts
            Console.WriteLine($"Ball 1 has been thrown {ball1.GetThrowCount()} times."); // Should print 2
            Console.WriteLine($"Ball 2 has been thrown {ball2.GetThrowCount()} times."); // Should print 1
        }
    }
}