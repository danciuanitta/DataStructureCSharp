
using System.Xml.Linq;

namespace CustomBTree
{
    public class SelfBalancedTree<T>
    {
        static readonly int COUNT = 10;

        public Node<T>? CreateTreeFromValues(List<T> treeValues)
        {
            if (treeValues is null || treeValues.Count == 0)
                return null;

            var root = new Node<T>();
            root.Value = treeValues[0];
            treeValues.RemoveAt(0);

            var middle = treeValues.Count / 2;
            var leftList = new List<T>();
            leftList.AddRange(treeValues.Take(middle));
            var rightList = new List<T>();
            rightList.AddRange(treeValues.Skip(middle).Take(middle + 1));

            root.LeftTree = CreateTreeFromValues(leftList);
            root.RightTree = CreateTreeFromValues(rightList);

            return root;
        }

        public Node<T>? CreateTreeInstance(int numberOfNodes)
        {
            if (numberOfNodes == 0)
                return null;

            var root = new Node<T>();
            int nbOfLeftNodes = numberOfNodes / 2;
            int nbOfRightNodes = numberOfNodes - nbOfLeftNodes - 1;

            root.LeftTree = CreateTreeInstance(nbOfLeftNodes);
            root.RightTree = CreateTreeInstance(nbOfRightNodes);

            return root;
        }

        public void DisplayInPreorder(Node<int>? root)
        {
            if (root is null)
                return;

            Console.WriteLine(root.Value);
            DisplayInPreorder(root.LeftTree);
            DisplayInPreorder(root.RightTree);
        }

        public void PrintTree(Node<int> root)
        {
            // Pass initial space count as 0
            PrintTree(root, 0);
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
