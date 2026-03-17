
namespace SingletonDesignPatternApp;

public sealed class SingletonApp
{
    private static SingletonApp? _instance = null;
    private static int counter = 0;
    private static readonly Lock _lockObject = new();

    private SingletonApp()
    {
        counter++;
    }

    public static SingletonApp Get
    {
        get
        {
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    _instance ??= new SingletonApp();
                    Console.WriteLine(counter);
                }
            }
            return _instance;
        }
    }

    public int GetCounter() => counter;

}
