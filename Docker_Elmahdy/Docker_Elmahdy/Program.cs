namespace Docker_Elmahdy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello , this is my first docker image");
            while (true)
            {
                Console.Write($"\r{DateTime.Now:yyyyy:MM:dd HH:mm:ss}");
                Thread.Sleep(1000);
            }
        }
    }
}
