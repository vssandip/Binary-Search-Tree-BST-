﻿using BST3;

namespace Binary_Search_Tree_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***** Welcome Binary-Search-Tree-BST ***** ");
            /*  BST<int> bst = new BST<int>(56);
              bst.add(30);
              bst.add(70);
              bst.show();*/

            /*  BST<int> bst = new BST<int>(56);
              bst.add(30);
              bst.add(70);
              bst.add(22);
              bst.add(40);
              bst.add(11);
              bst.add(3);
              bst.add(16);
              bst.add(60);
              bst.add(95);
              bst.add(65);
              bst.add(63);
              bst.add(67);
              bst.show();*/

            BST3<int> bst = new BST3<int>(56);
            bst.add(30);
            bst.add(70);
            bst.add(22);
            bst.add(40);
            bst.add(11);
            bst.add(3);
            bst.add(16);
            bst.add(60);
            bst.add(95);
            bst.add(65);
            bst.add(63);
            bst.add(67);
            bst.show();
            bool result = bst.ifexists(22, bst);
            Console.WriteLine(result);
        }
    }
}