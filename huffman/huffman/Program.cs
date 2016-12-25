using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffman
{
    class Program
    {
        static void Main(string[] args)
        {
            HuffmanCode huffmanCode = new HuffmanCode();
            huffmanCode.EncodeText();
            huffmanCode.DecodeText();
        }
    }
}
