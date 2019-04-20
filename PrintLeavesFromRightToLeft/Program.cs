using System;

namespace PrintLeavesFromRightToLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Leaf nodes from right to left!");
            Console.WriteLine("------------------------------------");

            BinaryTree binaryTree = GetBinaryTreeFromInput();
            Console.WriteLine();
            Console.WriteLine("---Inorder traversal---");
            binaryTree.InorderTraversal(binaryTree.GetBinaryTreeRoot());
            Console.WriteLine();
            Console.WriteLine("---Printing Leaves from Right to Left----");
            binaryTree.PrintLeavesFromRightToLeft(binaryTree.GetBinaryTreeRoot());


            Console.ReadLine();
        }

        private static BinaryTree GetBinaryTreeFromInput() {
            BinaryTree binaryTree = null;

            Console.WriteLine("Enter the number of elements in the" +
                " binary tree");
            try
            {
                int numberElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by" +
                    " comma, semi-colon or space");
                String[] elements = Console.ReadLine().Split(' ', ',', ';');
                BinaryTreeNode binaryTreeNode = null;
                binaryTree = new BinaryTree(binaryTreeNode);
                for (int index = 0; index < numberElements; index++) {
                    binaryTreeNode = binaryTree.Insert(binaryTreeNode,
                        int.Parse(elements[index]));
                }
                binaryTree.SetBinaryTreeNodeRoot(binaryTreeNode);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is" +
                    " "+exception.Message);
            }


            return binaryTree;

        }
    }
}
