namespace StrategyDesignPatterApp
{
    internal class ZipCompressionStrategy : ICompression
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Folder is compressed using Rar approach: '" + fileName + ".zip' file is created");
        }
    }
}
