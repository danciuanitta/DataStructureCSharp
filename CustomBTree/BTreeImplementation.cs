
namespace CustomBTree
{
    public class BTreeImplementation<T>
    {
        private int CountTotal = 0;
        private int CurrentPreorder = 0;
        private int CurrentPostorder = 0;
        private int CurrentInorder = 0;

        private Node<int>? Root;

        public Node<int>? CreateTreeFromList(List<int> bTreeValues)
        {
            if (bTreeValues is null || bTreeValues.Count == 0) 
                return null;

            if (Convert.ToInt32(bTreeValues[0]) == 0)
            {
                bTreeValues.RemoveAt(0);
                return null;
            }

            var root = new Node<int>();
            root.Value = bTreeValues[0];
            bTreeValues.RemoveAt(0);
            CountTotal += 1;
            if (Root is null)
                Root = root;

            root.LeftTree = CreateTreeFromList(bTreeValues); 
            root.RightTree = CreateTreeFromList(bTreeValues);



            return root;
        }

        public void DisplayInInorder(Node<int>? root)
        {
            if (root is not null)
            {
                DisplayInInorder(root.LeftTree);
                Console.WriteLine(root.Value);
                CurrentInorder += 1;
                DisplayInInorder(root.RightTree);
            }
            else if (CurrentInorder <= CountTotal)
            {
                Console.WriteLine(0);
            }
        }

        public void DisplayInPostorder(Node<int>? root)
        {
            if (root is not null)
            {
                DisplayInPostorder(root.LeftTree);
                DisplayInPostorder(root.RightTree);
                Console.WriteLine(root.Value);
                CurrentPostorder += 1;
            }
            else if (CurrentPostorder <= CountTotal)
            {
                Console.WriteLine(0);
            }
        }

        public void DisplayInPreorder(Node<int>? root)
        {
            if (root is not null)
            {
                Console.WriteLine(root.Value);
                CurrentPreorder += 1;
                DisplayInPreorder(root.LeftTree);
                DisplayInPreorder(root.RightTree);
            }
            else if (CurrentPreorder <= CountTotal)
            {
                Console.WriteLine(0);
            }

        }

        public int DisplayInternalNodes(Node<int>? root)
        {
            if (root?.LeftTree is not null || root?.RightTree is not null)
            {
                Console.WriteLine($"Node: {root.Value} ");
                return (1 + DisplayInternalNodes(root.LeftTree) + DisplayInternalNodes(root.RightTree));
            }

            return 0;
        }

        public int DisplayLeaves(Node<int>? root)
        {
            if (root is null)
            {
                return 0;
            }


            if (root.LeftTree is null && root.RightTree is null)
            {
                Console.WriteLine($"Leaf:{root.Value} ");
                return 1;
            }

            return (DisplayLeaves(root.LeftTree!) + DisplayLeaves(root.RightTree!));
        }

        public Node<int>? SearchValue(int value)
        {
            return SearchValueInNodes(Root, value);
        }

        private Node<int>? SearchValueInNodes(Node<int>? startingNode,int value)
        {
            if (startingNode is null)
                return null;

            if (startingNode.Value == value)
                return startingNode;

            if (startingNode.LeftTree is null && startingNode.RightTree is null)
                return null;

            return SearchValueInNodes(startingNode.LeftTree!, value) ?? SearchValueInNodes(startingNode.RightTree!, value);
        }
    }
}
