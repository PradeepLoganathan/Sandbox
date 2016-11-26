using System;

namespace BST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>();
            bst.AddNode(10);
            bst.AddNode(11);
            bst.AddNode(9);
            bst.AddNode(8);
            bst.AddNode(12);

            BSTNode<int> node = bst.FindNode(12);

        }
    }
}
