using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
     class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.root = tree.insert(tree.root, 10);
            tree.root = tree.insert(tree.root, 7);
            tree.root = tree.insert(tree.root, 12);
            tree.root = tree.insert(tree.root, 3);
            Console.WriteLine("root :" +  tree.root.data) ;
            Console.WriteLine("root :" +  tree.root.left.data) ;
            Console.WriteLine("root :" +  tree.root.right.data) ;
            Console.WriteLine("root :" +  tree.root.left.left.data) ;

            tree.inOrder(tree.root);
            Console.WriteLine();
            tree.postOrder(tree.root);
            Console.WriteLine();
            tree.preOrder(tree.root);
            Console.ReadLine();
        }
    }
}
