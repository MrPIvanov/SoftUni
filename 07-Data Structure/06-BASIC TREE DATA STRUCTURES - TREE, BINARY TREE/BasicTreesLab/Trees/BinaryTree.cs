using System;

public class BinaryTree<T>
{
    public T Value { get; set; }

    public BinaryTree<T> Left { get; set; }

    public BinaryTree<T> Right { get; set; }


    public BinaryTree(T value, BinaryTree<T> leftChild = null, BinaryTree<T> rightChild = null)
    {
        this.Value = value;
        this.Left = leftChild;
        this.Right = rightChild;
    }

    public void PrintIndentedPreOrder(int indent = 0)
    {
        this.PrintIndentedPreOrder(this, indent);
    }

    private void PrintIndentedPreOrder(BinaryTree<T> node, int indent)
    {
        if (node == null)
        {
            return;
        }

        Console.WriteLine($"{new string(' ', 2 * indent)}{node.Value}");

        node.PrintIndentedPreOrder(node.Left, indent + 1);

        node.PrintIndentedPreOrder(node.Right, indent + 1);

    }

    public void EachInOrder(Action<T> action)
    {
        this.EachInOrder(this, action);
    }

    private void EachInOrder(BinaryTree<T> node, Action<T> action)
    {
        if (node == null)
        {
            return;
        }

        node.EachInOrder(node.Left, action);

        action(node.Value);

        node.EachInOrder(node.Right, action);
    }

    public void EachPostOrder(Action<T> action)
    {
        this.EachPostOrder(this, action);
    }

    private void EachPostOrder(BinaryTree<T> node, Action<T> action)
    {
        if (node == null)
        {
            return;
        }

        node.EachPostOrder(node.Left, action);

        node.EachPostOrder(node.Right, action);

        action(node.Value);
    }
}
