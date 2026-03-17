namespace SingletonDesignPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = SingletonApp.Get;
            Console.WriteLine(app.GetCounter());

            var app1 = SingletonApp.Get;
            Console.WriteLine(app1.GetCounter());

        }
    }
}
