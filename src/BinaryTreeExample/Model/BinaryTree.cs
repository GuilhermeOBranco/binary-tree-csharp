using BinaryTreeExample.Model;

public class BinaryTree{
    public Node root;

    public BinaryTree()
    {
        root = null;
    }

    public void Insert(int data)
    {
        root = InsertData(root, data);
    }

    private Node InsertData(Node root, int data)
    {
        if (root == null)
            root = new Node(data);

        if(data < root.Data)
            root.Left = InsertData(root.Left, data);
        
        if(data > root.Data)
            root.Right = InsertData(root.Right, data);


        return root;
    }

    public int Height()
    {
        return GetSize(root);
    }

    private int GetSize(Node root){
        
        if(root == null)
            return -1;
        
        int leftSize = GetSize(root.Left);
        int rightSize = GetSize(root.Right);

        return Math.Max(leftSize, rightSize) +1;
    }
}