namespace Demo.cs
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Random h = new Random();
            int hari = h.Next(0,2);
           // Console.WriteLine(hari);
            if (hari == 1)
            {
                Console.WriteLine("Emp is present");
            }
            else
            {
                Console.WriteLine("emp is absent");
            }
        }
    }
}