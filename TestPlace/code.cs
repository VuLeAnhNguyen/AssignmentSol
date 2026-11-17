using System.Collections.Generic;
class Program
{
    public class Node
    {
        public int Value;
        public Node? Parent = null;
        public Node? Lchild = null;
        public Node? Rchild = null;
        public Node(int _value)
        {
            Value = _value;
        }
        public Node(int _value, Node _parent)
        {
            Value = _value;
            Parent = _parent;
        }
        public void Print()
        {
            Console.Write("\t" + Value);
        }
    }
    public static void PreorderTraversal(Node? root)
    {
        if (root == null) return;
        root.Print();
        PreorderTraversal(root.Lchild);
        PreorderTraversal(root.Rchild);
    }
    public static void InorderTraversal(Node? root)
    {
        if (root == null) return;
        InorderTraversal(root.Lchild);
        root.Print();
        InorderTraversal(root.Rchild);
    }
    public static void PostorderTraversal(Node? root)
    {
        if (root == null) return;
        PostorderTraversal(root.Lchild);
        PostorderTraversal(root.Rchild);
        root.Print();
    }
    public Node? BinaryTree(int[] array)
    {
        if (array.Length < 1) return null;
        Node root = new(array[0]);

        for (int i = 1; i < array.Length; i++)
        {
            Node current = root;
            while (true)
            {
                if (array[i] < current.Value)
                {
                    if (current.Lchild == null)
                    {
                        current.Lchild = new Node(array[i], current);
                        break;
                    }
                    else
                        current = current.Lchild;
                }
                else
                {
                    if (current.Rchild == null)
                    {
                        current.Rchild = new Node(array[i], current);
                        break;
                    }
                    else
                        current = current.Rchild;
                }
            }
        }
        return root;
    }
    static void Main()
    {

    }
}