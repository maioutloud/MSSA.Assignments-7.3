using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_7._3
{
    // create class node
    internal class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node(int value, Node left, Node right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }

    // create class binary search tree
    class BinarySearchTree
    {
        public Node root;   // set to null
        public BinarySearchTree()
        {
            root = null;
        }
        public void InOrder(Node temproot)
        {
            if(temproot != null)
            {
                InOrder(temproot.left);
                Console.Write(temproot.value + " ");
                InOrder(temproot.right);
            }
        }
        public void PreOrder(Node temproot)
        {
            if(temproot != null)
            {
                Console.Write(temproot.value + " ");
                PreOrder(temproot.left);
                PreOrder(temproot.right);
            }
        }
        public void PostOrder(Node temproot)
        {
            if(temproot != null)
            {
                PostOrder(temproot.left);
                PostOrder(temproot.right);
                Console.Write(temproot.value + " ");
            }
        }
        public Node RecInsert(Node temproot, int e)
        {
            if(temproot != null)
            {
                if (e < temproot.value)
                    temproot.left = RecInsert(temproot.left, e);
                if (e > temproot.value)
                    temproot.right = RecInsert(temproot.right, e);
            }
            else
            {
                Node n = new Node(e, null, null);
                temproot = n;
            }
            return temproot;
        }
        public bool RecSearch(Node temproot, int key)
        {
            if (temproot!=null)
            {
                if (key == temproot.value)
                    return true;
                else if (key < temproot.value)
                    return RecSearch(temproot.left, key);
                else if (key > temproot.value)
                    return RecSearch(temproot.right, key);
            }
            return false;
        }
    }
}
