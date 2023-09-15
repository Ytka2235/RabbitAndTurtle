internal class Program
{

    public static int x = 0; public static int y = 0;
    private static void Main(string[] args)
    {
        Thread Rabbit = new Thread(RunRabbit);
        Thread Turtle = new Thread(RunTurtle);
        Rabbit.Start();
        Turtle.Start();
        while (x == 100 || y == 100)
        {
            if (x > (y + 10))
            {
                Turtle.Priority = ThreadPriority.Normal;
                Rabbit.Priority = ThreadPriority.Lowest;
            }
            if (y > (x + 10))
            {
                Turtle.Priority = ThreadPriority.Lowest;
                Rabbit.Priority = ThreadPriority.Normal;
            }
        }
        Console.ReadKey();

    }

    public static void RunRabbit()
    {
        for ( x = 0; x < 1001; x++)
        {
            Console.WriteLine("Rabbit пробежал {0} метров",  x);
            
        }
    }

    public static void RunTurtle()
    {
        for (y = 0; y < 1001; y++)
        {
            Console.WriteLine("Turtle пробежал {0} метров", y);
            
        }
    }
}