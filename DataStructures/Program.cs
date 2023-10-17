// See https://aka.ms/new-console-template for more information
using CustomBTree;

Console.WriteLine("Hello, World!");


#region singleLinkedList
//Console.ReadLine();
//CustomSingleLinkedListWithLast<Student> customSingleLinkedListWithLast = new CustomSingleLinkedListWithLast<Student>();

//var specificStudent1 = new Student()
//{
//    Name = "a1",
//    Address = "b1"
//};
//var specificStudent2 = new Student()
//{
//    Name = "a2",
//    Address = "b"
//};
//var specificStudent3 = new Student()
//{
//    Name = "a3",
//    Address = "b"
//};
//var specificStudent4 = new Student()
//{
//    Name = "a4",
//    Address = "b"
//};
//customSingleLinkedListWithLast.Add(specificStudent1);
//customSingleLinkedListWithLast.Add(specificStudent2);
//customSingleLinkedListWithLast.Add(specificStudent3);
//customSingleLinkedListWithLast.Add(specificStudent4);

//customSingleLinkedListWithLast.DisplayNodes();

//customSingleLinkedListWithLast.RemoveLast();

//customSingleLinkedListWithLast.DisplayNodes();

//customSingleLinkedListWithLast.RemoveFirst();

//customSingleLinkedListWithLast.DisplayNodes();

//customSingleLinkedListWithLast.Remove(specificStudent2);

//customSingleLinkedListWithLast.DisplayNodes();

#endregion

#region BTree
//Console.ReadLine();
//var bTreeValues = new List<int>() { 1, 7, 2, 0, 5, 0, 0, 0, 9, 3, 0, 0, 4, 0, 6, 0, 0 };

//var bTree = new BTreeImplementation<int>();

//Node<int>? root = bTree.CreateTreeFromList(bTreeValues);

//if (root == null)
//{
//    Console.WriteLine("No tree created.");
//}

//Console.WriteLine("Display in preorder:");
//bTree.DisplayInPreorder(root);
//Console.WriteLine("Display in inorder:");
//bTree.DisplayInInorder(root);
//Console.WriteLine("Display in postorder:");
//bTree.DisplayInPostorder(root);

//var nbOfLeaves = bTree.DisplayLeaves(root);
//Console.WriteLine($"Total number of leaves: {nbOfLeaves}");

//var nbOfNodes = bTree.DisplayInternalNodes(root);
//Console.WriteLine($"Total number of nodes: {nbOfNodes}");

//var searchedNode1 = bTree.SearchValue(3);

//if (searchedNode1 is not null)
//    Console.WriteLine("Value 3 is found");
//else
//    Console.WriteLine("Value 3 is not found");

//var searchedNode2 = bTree.SearchValue(300);

//if (searchedNode2 is not null)
//    Console.WriteLine("Value 300 is found");
//else
//    Console.WriteLine("Value 300 is not found");
#endregion

#region sbt
Console.ReadLine();
var sbTreeValues = new List<int>() { 1, 7, 2, 0, 5, 0, 0, 0, 9, 3, 0, 0, 4, 0, 6, 0, 0 };
var sbTree = new SelfBalancedTree<int>();

var sbRoot = sbTree.CreateTreeFromValues(sbTreeValues);
Console.WriteLine("Display in preorder:");
sbTree.DisplayInPreorder(sbRoot);

sbTree.print2D(sbRoot);

#endregion
Console.ReadLine();