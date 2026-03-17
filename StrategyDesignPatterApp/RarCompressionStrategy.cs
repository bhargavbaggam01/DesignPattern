using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPatterApp
{
    internal class RarCompressionStrategy : ICompression
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Folder is compressed using Rar approach: '" + fileName + ".rar' file is created");
        }
    }
}
