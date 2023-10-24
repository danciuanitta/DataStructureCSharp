
namespace CustomBTree
{
    public class BinarySearchTree
    {
        Node<int>? Root;
        static readonly int COUNT = 10;
        public void InsertValue(int value)
        {
            if (Root is null)
            {
                Root = new Node<int>();
                Root.Value = value;
                return;
            }

            InsertValueInTree(Root, value);

            //if (Root.Value <= value && Root.RightTree is null)
            //{
            //    Root.RightTree = new Node<int>();
            //    Root.RightTree.Value = value;
            //    return;
            //}

            //if (Root.Value > value && Root.LeftTree is null)
            //{
            //    Root.LeftTree = new Node<int>();
            //    Root.LeftTree.Value = value;
            //    return;
            //}

            //if (Root.Value <= value)
            //    InsertValueInTree(Root.RightTree, value);
            //else
            //    InsertValueInTree(Root.LeftTree, value);

            return;
        }

        private void InsertValueInTree(Node<int>? root, int value)
        {
            if (root is null)
            {
                root = new Node<int>();
                root.Value = value;
                return;
            }

            if (value < root.Value && root.LeftTree is null)
            {
                root.LeftTree = new Node<int>();
                root.LeftTree.Value = value;
                return;
            }

            if (root.Value <= value && root.RightTree is null)
            {
                root.RightTree = new Node<int>();
                root.RightTree.Value = value;
                return;
            }

            if (value < root.Value)
                InsertValueInTree(root.LeftTree, value);
            else
                InsertValueInTree(root.RightTree, value);
        }

        public void DisplayInPreorder()
        {
            if (Root is not null)
            {
                Console.WriteLine(Root.Value);
                DisplayInPreorder(Root.LeftTree);
                DisplayInPreorder(Root.RightTree);
            }

            return;

        }
        private void DisplayInPreorder(Node<int>? root)
        {
            if (root is not null)
            {
                Console.WriteLine(root.Value);
                DisplayInPreorder(root.LeftTree);
                DisplayInPreorder(root.RightTree);
            }

            return;

        }

        public void PrintTree()
        {
            // Pass initial space count as 0
            PrintTree(Root, 0);
        }

        private void PrintTree(Node<int>? root, int space)
        {
            // Base case
            if (root == null)
                return;

            // Increase distance between levels
            space += COUNT;

            // Process right child first
            PrintTree(root.RightTree, space);

            // Print current node after space
            // count
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
                Console.Write(" ");
            Console.Write(root.Value + "\n");

            // Process left child
            PrintTree(root.LeftTree, space);
        }
    }
}
