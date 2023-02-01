namespace Binary_Search_Tree_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ***** Welcome Binary-Search-Tree-BST ***** ");
            BST<int> bst = new BST<int>(56);
            bst.add(30);
            bst.add(70);
            bst.show();
        }
    }
}