using System;

namespace BST
{
    public  class BSTNode<T> where T:IComparable<T>
    {
        private T _data;
        private BSTNode<T> _left, _right;

        public T Data { get { return _data; } set { _data = value; } }
        public BSTNode<T> Left { get { return _left; } set { _left = value; } }
        public BSTNode<T> Right { get { return _right;} set {_right = value; }}

        public  static BSTNode<T> CreateNode(T Data)
        {
           BSTNode<T> newnode =  new BSTNode<T>() { _data = Data, Left = null, Right = null };
           return newnode;
        }

    }
    public class BinarySearchTree<T> where T:IComparable<T>
    {
        private BSTNode<T> _root;
        public BSTNode<T> Root {get { return _root; } set {_root = value; } } 


        public BinarySearchTree()
        {
            _root = null;
        }
        public void AddNode(T Data)
        {
            if(_root == null)            
                _root = BSTNode<T>.CreateNode(Data);
            else
                AddNode(_root, Data);            
        }
        private void AddNode(BSTNode<T> current,T  Data)
        {
            if(current.Data.CompareTo(Data) < 0)
            {
                if(current.Right == null)
                    current.Right = BSTNode<T>.CreateNode(Data);
                else
                    AddNode(current.Right, Data);
            }
            if(current.Data.CompareTo(Data) > 0)
            {
                if(current.Left == null)
                    current.Left = BSTNode<T>.CreateNode(Data);
                else
                    AddNode(current.Left, Data);
            }
        }
        public BSTNode<T> RemoveNode(T Data)
        {
            return null;
        }

        public BSTNode<T> FindNode(T Data)
        {
            BSTNode<T> node = null;

            if(_root == null)
                return _root;
            
            node = FindNode(_root, Data);
            return node;
        }

        private BSTNode<T> FindNode(BSTNode<T> current, T Data )
        {
            if(current == null)
                return null;

            if(current.Data.CompareTo(Data) > 0 )
                return FindNode(current.Left, Data);
            else if(current.Data.CompareTo(Data) < 0 )
                return FindNode(current.Right, Data);
            else
                return current;
        }

    }
}