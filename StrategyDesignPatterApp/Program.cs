namespace StrategyDesignPatterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICompression strategy = new ZipCompressionStrategy();
            CompressionContext ctx = new CompressionContext(strategy);
            ctx.Compress("DotNetDesignPattern");

            //Changing the Strategy using SetStrategy Method
            ctx.SetStrategy(new RarCompressionStrategy());
            ctx.Compress("DotNetDesignPattern");
        }
    }
}
