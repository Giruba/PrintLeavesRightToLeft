using System;
using System.Collections.Generic;
using System.Text;

namespace PrintLeavesFromRightToLeft
{
    class BinaryTree
    {
        BinaryTreeNode root;

        public BinaryTree(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }

        public void SetBinaryTreeNodeRoot(BinaryTreeNode binaryTreeNode) {
            root = binaryTreeNode;
        }

        public BinaryTreeNode GetBinaryTreeRoot() {
            return root;
        }

        public BinaryTreeNode Insert(BinaryTreeNode node, int data) {
            if (node == null) {
                node = new BinaryTreeNode(data);
                return node;
            }

            if (node.GetBinaryTreeNodeData() < data)
            {
                node.SetBinaryTreeNodeRight(Insert(node.GetBinaryTreeNodeRight(),
                    data));
            }
            else {
                node.SetBinaryTreeNodeLeft(Insert(node.GetBinaryTreeNodeLeft(),
                    data));
            }

            return node;
        }

        public void PrintLeavesFromRightToLeft(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return;
            }
            if (binaryTreeNode.GetBinaryTreeNodeLeft() == null &&
                binaryTreeNode.GetBinaryTreeNodeRight() == null) {
                Console.Write(binaryTreeNode.GetBinaryTreeNodeData()+ " ");
            }

            PrintLeavesFromRightToLeft(binaryTreeNode.GetBinaryTreeNodeRight());
            PrintLeavesFromRightToLeft(binaryTreeNode.GetBinaryTreeNodeLeft());

        }

        public void InorderTraversal(BinaryTreeNode binaryTreeNode) {
            if (binaryTreeNode == null) {
                return;
            }
            InorderTraversal(binaryTreeNode.GetBinaryTreeNodeLeft());
            Console.Write(binaryTreeNode.GetBinaryTreeNodeData()+" ");
            InorderTraversal(binaryTreeNode.GetBinaryTreeNodeRight());

        }
    }
}
