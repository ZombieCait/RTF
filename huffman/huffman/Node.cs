using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace huffman
{
    class Node
    {
        public char Symbol;
        public double Frequency;
        public Node LeftChild;
        public Node RightChild;

        public List<bool> Move(char symbol, List<bool> data)
        {
            if (this.IsLeaf())
            {
                if (symbol.Equals(this.Symbol))
                {
                    return data;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                List<bool> left = null;
                List<bool> right = null;

                if (LeftChild != null)
                {
                    List<bool> leftPath = new List<bool>();
                    leftPath.AddRange(data);
                    leftPath.Add(false);

                    left = LeftChild.Move(symbol, leftPath);
                }

                if (RightChild != null)
                {
                    List<bool> rightPath = new List<bool>();
                    rightPath.AddRange(data);
                    rightPath.Add(true);
                    right = RightChild.Move(symbol, rightPath);
                }

                if (right != null)
                {
                    return right;
                }
                else
                {
                    return left;
                }
            }
        }
        public bool IsLeaf()
        {
            return (this.LeftChild == null && this.RightChild == null);
        }
    }
}
