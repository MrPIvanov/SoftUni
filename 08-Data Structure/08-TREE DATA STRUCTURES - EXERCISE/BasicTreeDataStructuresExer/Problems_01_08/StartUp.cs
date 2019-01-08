using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static Dictionary<int, Tree<int>> tree = new Dictionary<int, Tree<int>>();

    static void Main()
    {
        ReadInputAndFillTree();

        ////---Problem_01_Root Node
        //PrintRootNode();

        ////---Problem_02_Print Tree
        //var root = tree.FirstOrDefault(x => x.Value.Parrent == null).Value;
        //var indented = 0;
        //PrintTree(root, indented);

        ////---Problem_03_Leaf Nodes
        //PrintAllLeafs();

        ////---Problem_04_Middle Nodes
        //PrintMiddleNodes();

        ////---Problem_05_Deepest Node
        //var root = tree.FirstOrDefault(x => x.Value.Parrent == null).Value;
        //var longestLenght = 0;
        //var deepestNodeValue = 0;
        //var currentLenght = 0;
        //PrintDeepestNode(root, ref longestLenght, ref deepestNodeValue, currentLenght);
        //Console.WriteLine($"Deepest node: {deepestNodeValue}");

        ////---Problem_06_Longest Path
        //var root = tree.FirstOrDefault(x => x.Value.Parrent == null).Value;
        //Tree<int> deepestNode = root;
        //var longestLenght = 0;
        //var currentLenght = 0;
        //FindDeepestNode(root, ref deepestNode, ref longestLenght, currentLenght);
        //PrintDeepestNodePath(deepestNode);

        ////---Problem_07_All Paths With a Given Sum
        //var pathSum = int.Parse(Console.ReadLine());
        //var root = tree.FirstOrDefault(x => x.Value.Parrent == null).Value;
        //List<Tree<int>> correctNodes = new List<Tree<int>>();
        //var currentSum = root.Value;
        //FindAllNodesWithCurrentPath(root, correctNodes, currentSum, pathSum);
        //Console.WriteLine($"Paths of sum {pathSum}:");
        //PrintAllPaths(correctNodes);

        //---Problem_08_All Subtrees With a Given Sum
        var targetSum = int.Parse(Console.ReadLine());
        var root = tree.FirstOrDefault(x => x.Value.Parrent == null).Value;
        var allCorectRoots = new List<Tree<int>>();
        
        GetAllRoots(root, allCorectRoots, targetSum, 0);
        Console.WriteLine($"Subtrees of sum {targetSum}:");

        foreach (var corectRoot in allCorectRoots)
        {
            var result = new List<int>();

            GetCorrectValuesFromSubTree(corectRoot, result);

            Console.WriteLine($"{string.Join(" ", result)}");
        }
    }

    private static void GetCorrectValuesFromSubTree(Tree<int> corectRoot, List<int> result)
    {
        result.Add(corectRoot.Value);

        foreach (var child in corectRoot.Childrens)
        {
            GetCorrectValuesFromSubTree(child, result);
        }
    }

    private static int GetAllRoots(Tree<int> node, List<Tree<int>> allCorectRoots, int targetSum, int current)
    {
        if (node == null)
        {
            return 0;
        }

        current = node.Value;

        foreach (var child in node.Childrens)
        {
            current += GetAllRoots(child, allCorectRoots, targetSum, current);
        }

        if (current == targetSum)
        {
            allCorectRoots.Add(node);
        }
        return current;
    }

    private static void PrintAllPaths(List<Tree<int>> correctNodes)
    {
        foreach (var endNode in correctNodes)
        {
            var current = endNode;
            var stack = new Stack<int>();

            while (current.Parrent != null)
            {
                stack.Push(current.Value);
                current = current.Parrent;
            }
            stack.Push(current.Value);

            Console.WriteLine($"{string.Join(" ", stack)}");
        }
    }

    private static void FindAllNodesWithCurrentPath(Tree<int> root, List<Tree<int>> correctNodes, int currentSum, int pathSum)
    {
        if (currentSum == pathSum)
        {
            correctNodes.Add(root);
        }

        foreach (var child in root.Childrens)
        {
            FindAllNodesWithCurrentPath(child, correctNodes, currentSum + child.Value, pathSum);
        }
    }

    private static void PrintDeepestNodePath(Tree<int> deepestNode)
    {
        var stack = new Stack<int>();

        while (deepestNode.Parrent != null)
        {
            stack.Push(deepestNode.Value);
            deepestNode = deepestNode.Parrent;
        }
        stack.Push(deepestNode.Value);

        Console.WriteLine($"Longest path: {string.Join(" ", stack)}");
    }

    private static void FindDeepestNode(Tree<int> root, ref Tree<int> deepestNode, ref int longestLenght, int currentLenght)
    {
        if (currentLenght > longestLenght)
        {
            longestLenght = currentLenght;
            deepestNode = root;
        }

        foreach (var child in root.Childrens)
        {
            FindDeepestNode(child, ref deepestNode, ref longestLenght, currentLenght + 1);
        }
    }

    private static void PrintDeepestNode(Tree<int> root, ref int longestLenght, ref int deepestNodeValue, int currentLenght)
    {
        if (currentLenght > longestLenght)
        {
            longestLenght = currentLenght;
            deepestNodeValue = root.Value;
        }
        foreach (var child in root.Childrens)
        {
            PrintDeepestNode(child, ref longestLenght, ref deepestNodeValue, currentLenght + 1);
        }
    }

    private static void PrintMiddleNodes()
    {
        var middleNodes = tree
                                .Where(x => x.Value.Parrent != null)
                                .Where(x => x.Value.Childrens.Count > 0)
                                .OrderBy(x => x.Key)
                                .Select(x => x.Key)
                                .ToList();

        Console.WriteLine($"Middle nodes: {string.Join(" ", middleNodes)}");
    }

    private static void PrintAllLeafs()
    {
        var leafs = tree
                        .Where(x => x.Value.Childrens.Count == 0)
                        .OrderBy(x => x.Key)
                        .Select(x => x.Key)
                        .ToList();

        Console.WriteLine($"Leaf nodes: {string.Join(" ", leafs)}");
    }

    private static void PrintTree(Tree<int> root, int indented)
    {
        Console.WriteLine($"{new string(' ', indented)}{root.Value}");

        foreach (var child in root.Childrens)
        {
            PrintTree(child, indented + 2);
        }
    }

    private static void PrintRootNode()
    {
        var rootNode = tree.FirstOrDefault(x => x.Value.Parrent == null).Key;

        Console.WriteLine($"Root node: {rootNode}");
    }

    private static void ReadInputAndFillTree()
    {
        var numberOfNodes = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfNodes - 1; i++)
        {
            var nodes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var parrentValue = nodes[0];
            var childValue = nodes[1];

            if (!tree.ContainsKey(parrentValue))
            {
                tree.Add(parrentValue, new Tree<int>(parrentValue));
            }

            if (!tree.ContainsKey(childValue))
            {
                tree.Add(childValue, new Tree<int>(childValue));
            }

            tree[parrentValue].Childrens.Add(tree[childValue]);
            tree[childValue].Parrent = tree[parrentValue];
        }
    }
}

public class Tree<T>
{
    public T Value { get; set; }

    public List<Tree<T>> Childrens { get; set; }

    public Tree<T> Parrent { get; set; }

    public Tree(T value, params Tree<T>[] childrens)
    {
        this.Value = value;
        this.Childrens = new List<Tree<T>>(childrens);
        this.Parrent = null;
    }
}