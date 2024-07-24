namespace Assignments_7._3
{
    internal class Program
    {
        // ASSIGNMENTS 7.3
        // CCAD12 : MAI LOR
        // 7.3.1 Shell Sort
        // 7.3.2 Binary Search Tree; insert node; search node
        static void ShellSort(int[] array)
        {
            int gap = array.Length / 2; // find gap
            int i;  
            int j;  
            while(gap > 0)  // sort with decreasing gap sizes until gap is 0
            {
                i = gap;    // set temporary gap size
                while(i < array.Length)     // iterate while gap is less than array size
                {
                    int temp = array[i];    // store gap element in temp
                    j = i - gap;            // initialize index of the element to be compared
                    while(j>=0 && array[j]>temp)    // compare elements with given gap value
                    {
                        array[j + gap] = array[j];  // shift elements to the right
                        j = j - gap;                // move to previous element
                    }
                    array[j + gap] = temp; // put stored element in correct position
                    i++;                   // move to next position in array
                }
                gap = gap / 2;  // reduce size of gap for next iteration
            }
        }
        static void Display(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("ASSIGNMENTS 7.3");
            Console.WriteLine("CCAD12 : MAI LOR\n");
            
            Console.WriteLine("ASSIGNMENTS 7.3.1 : SHELL SEARCH\n");

            // 7.3.1 shell sort array
            int[] array = { 5, 2, 1, 11, 9 };
            Console.WriteLine("Unsorted Array: ");
            Display(array); 
            Console.WriteLine("\nUsing Shell Sort: ");
            ShellSort(array);
            Display(array);

            // 7.3.2 binary tree
            BinarySearchTree tree = new BinarySearchTree();     // create new Binary Search Tree
            tree.root = tree.RecInsert(tree.root, 25);          // create root
            tree.RecInsert(tree.root, 50);                      // insert subs
            tree.RecInsert(tree.root, 30);
            tree.RecInsert(tree.root, 10);
            tree.RecInsert(tree.root, 60);
            tree.RecInsert(tree.root, 75);
            tree.RecInsert(tree.root, 80);

            // display binary tree
            Console.WriteLine("\n\nASSIGNMENTS 7.3.2 : BINARY SEARCH TREE");
            Console.Write("\nInOrder (a+b):   ");   
            tree.InOrder(tree.root);                // inorder
            Console.Write("\nPreOrder (+ab):  ");   
            tree.PreOrder(tree.root);               // preorder
            Console.Write("\nPostOrder (ab+): ");   
            tree.PostOrder(tree.root);              // postorder

            // search binary tree
            Console.Write("\n\nEnter a value to search the Binary Tree: ");   
            int key = Int32.Parse(Console.ReadLine());          
            bool val = tree.RecSearch(tree.root, key);
            if (val)
            {
                Console.WriteLine($"\n{key} was found!!");
            }
            else
            {
                Console.WriteLine($"\n{key} was not found!");
            }
            Console.ReadKey();
        }
    }
}