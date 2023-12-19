using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BinaryTreeExample.Model
{
    public class Node
    {
        public int Data;
        public Node Left, Right;

        public Node(int item)
        {
            Data = item;
            Left = Right = null;
        }
    }

}