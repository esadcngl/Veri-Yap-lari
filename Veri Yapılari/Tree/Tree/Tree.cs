using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Tree
    {
        public Node root;

        public Tree()
        {
            root = null;
        }

        public Node newNode(int data)
        {
            root = new Node(data);
            return root;
        }
        public Node insert(Node root, int data)
        {

            if (root != null)
            {
                if (data < root.data)
                {
                    root.left = insert(root.left, data);
                }
                else
                {
                    root.right = insert(root.right, data);
                }
            }
            else
            {
                root = newNode(data);
            }
            return root;
        }
        public void preOrder(Node root)
        {
            if (root!=null)
            {
                Console.Write(root.data + " " );
                preOrder(root.left);
                preOrder(root.right);
            }
        }
        public void inOrder(Node root)
        {
            if (root !=null)
            {
                inOrder(root.left);
                Console.Write(root.data + " ");
                inOrder(root.right);
            }
        }
        public void postOrder(Node root)
        {
            if (root != null)
            {
                postOrder(root.left);
                postOrder(root.right);
                Console.Write(root.data + " ");
            }
        }
        public int size(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return size(root.left) + 1 + size(root.right);
            }
        }
    }
}
