using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffman
{
    class HuffmanCode
    {
        private string Text;
        private Dictionary<char, int> TextSymbols;
        private List<Node> Nodes = new List<Node>();
        private Node Root;
        private Dictionary<char, List<bool>> СodeTable;
        private BitArray Bits;

        public void EncodeText()
        {
            Text = File.ReadAllText("text.txt");
            CalculateSymbolsFrequencyInText();
            BuildTree();

            List<bool> EncodedText = new List<bool>();
            СodeTable = new Dictionary<char, List<bool>>();//таблица символ-код
            for (int i = 0; i < Text.Length; i++)
            {
                List<bool> encodedSymbol = Root.Move(Text[i], new List<bool>());
                if (!СodeTable.ContainsKey(Text[i]))
                    СodeTable.Add(Text[i], encodedSymbol);
                EncodedText.AddRange(encodedSymbol);
            }
            this.Bits = new BitArray(EncodedText.ToArray());
            WriteTable("codeTable.txt");
            WriteBitsFile("encodedText.txt");
        }
        public void DecodeText()
        {
            Node current = Root;
            string decoded = "";

            foreach (bool bit in this.Bits)
            {
                if (bit && current.RightChild != null)
                    current = current.RightChild;
                else if (!bit && current.LeftChild != null)
                    current = current.LeftChild;

                if (current.IsLeaf())
                {
                    decoded += current.Symbol;
                    current = this.Root;
                }
            }
            WriteFile(decoded, "decodedText.txt");

        }
        private void BuildTree()
        {
            foreach (KeyValuePair<char, int> symbol in TextSymbols)
            {
                Nodes.Add(new Node() { Symbol = symbol.Key, Frequency = symbol.Value });
            }
            while (Nodes.Count > 1)
            {
                Nodes = Nodes.OrderBy(node => node.Frequency).ToList<Node>();

                while (Nodes.Count >= 2)
                {
                    List<Node> takenNodes = Nodes.Take(2).ToList<Node>(); //берем два узла дерева с наименьшими весами
                    Node parent = new Node
                    { //создаем родителя с общим весом этих узлов
                        Symbol = 'p',  
                        Frequency = takenNodes[0].Frequency + takenNodes[1].Frequency,
                        LeftChild = takenNodes[0],
                        RightChild = takenNodes[1]
                    };
                    Nodes.Remove(takenNodes[0]);
                    Nodes.Remove(takenNodes[1]);
                    Nodes.Add(parent);
                }
                Root = Nodes.First<Node>();             
            }
        }
        private void CalculateSymbolsFrequencyInText()
        {
            TextSymbols = Text.GroupBy(letter => letter)
                                 .OrderBy(pair => pair.Key)
                                 .ToDictionary(group => group.Key, group => group.Count());
        }
        private void WriteBitsFile(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (bool bit in this.Bits)
                {
                    writer.Write(bit ? 1 : 0);
                }
                writer.Close();
            }
        }
        private void WriteFile(string result, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(result);
                writer.Close();
            }
        }
        private void WriteTable(string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (KeyValuePair<char, List<bool>> symbol in СodeTable)
                {

                    writer.Write(symbol.Key);
                    writer.Write(' ');
                    foreach (bool bit in symbol.Value)
                    {
                        writer.Write(bit ? 1 : 0);
                    }
                    writer.WriteLine();
                }

                writer.Close();
            }
        }
    }
}
