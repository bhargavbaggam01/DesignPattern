namespace ObserverDesignPatternApp
{
    internal class Observer : IObserver
    {
        public string UserName { get; set; }

        public Observer(string userName)
        {
            UserName = userName;
        }

        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }
        //Observer will get a notification from the Subject using the following Method
        public void Update(string availabiliy)
        {
            Console.WriteLine("Hello " + UserName + ", Product is now " + availabiliy + " on Amazon");
        }
    }
}