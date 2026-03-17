namespace ObserverDesignPatternApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Observer ob1 = new Observer("Ram");
            Observer ob2 = new Observer("Sita");
            Observer ob3 = new Observer("Laxman");


            Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
            RedMI.RegisterObserver(ob1);
            RedMI.RegisterObserver(ob2);
            RedMI.RegisterObserver(ob3);

            RedMI.SetAvailability("Available");


        }
    }
}
