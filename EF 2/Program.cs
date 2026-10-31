namespace EF_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            using var db = new DBContext();

            Console.WriteLine("EventHub Application Started!");
        }
    }
}
