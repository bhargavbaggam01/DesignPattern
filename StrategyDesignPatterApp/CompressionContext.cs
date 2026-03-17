namespace StrategyDesignPatterApp
{
    internal class CompressionContext
    {
        private ICompression Compression;

        public CompressionContext(ICompression compression)
        {
            Compression = compression;
        }

        public void SetStrategy(ICompression compression)
        {
            this.Compression = compression;
        }

        public void Compress(string fileName)
        {
            Compression.Compress(fileName);
        }
    }
}
