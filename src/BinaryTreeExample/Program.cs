byte sizeTree = byte.Parse(Console.ReadLine());

byte[] treeValues =  Console.ReadLine().Split(' ').Select(x => byte.Parse(x)).ToArray();

BinaryTree binaryTree = new BinaryTree();


for (int nodeIndex = 0; nodeIndex < sizeTree; nodeIndex ++)
{
    binaryTree.Insert(treeValues[nodeIndex]);
}

int Height = binaryTree.Height();

Console.WriteLine(Height);



