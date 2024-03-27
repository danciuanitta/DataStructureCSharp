# Tree
It is a hierarchical data structure, containing a collection of elements, called *nodes* connected by *edges*.
It has a *root* node at the top, and every node in the tree has zero or more child nodes.
Nodes in a tree have a *parent-child* relationship, except for the root node, which has no parent.

- Each node has exactly one parent, except for the root node.
- There is a unique path from the root node to every other node in the tree.
- Trees do not contain cycles;

Glossary:
- parent node: predecessor of a node;
- child node: immediat successor of a node;
- root-node: top most node, with no parent nodes;
- leaf-node: last nodes, with no children;
- ancestor: any predecessor;
- descendant
- neighbour: parent or children of a node are called neighbors of that node;
- sibling: children of same parent node;
- subtree: any node of the tree along with its descendant;

Properties:
- number of edges
- depth of a node
- height of a node
- height of a tree
- degree of a node


Operations:
- create
- insert
- search
- delete
  
Traversal:
- **pre-order** \[Root, Left, Right\]: you start from root node, then visit left-tree recursively and then the right subtree; 

The following array [1,2,3,4,,5], would build the following binary tree after pre-order traversal:
              
  ![trees](https://github.com/danciuanitta/DataStructureCSharp/assets/38571093/e3037b09-d827-42ee-a1ee-d9a3fa6a494d)

- **post-order** [Left, Right, Root];
  
- **in-order** [Left, Root, Right];
  
Examples of trees:
- **binary-trees**: is a tree data structure, where each node has at most 2 children. Each nodes contains: the value to be stored, a refference to the left child and a refference to the right child.
- **binary-search trees**: it is a special binary tree, because for every parent node, the left child has a smaller value and the right child has a greater value, so the root has the smallest value in the left tree, but the greatest in the right one. This makes it efficient for search operations (O(logn)).
- **AVL** or self-balanced binary-search trees, where the difference between height of left subtrees and right subtrees can not be more than 1 (known as *balance factor*). In order to keep itself balanced (so never become *skewed*), it need to rotate at each insert or delete.
- **Red-Black trees**: special type of self-balanced binary search trees, where each node has an extra bit (0 or 1 interpreted as the collor: red or black). The height of a Red-Black tree is always O(log n) where n is the number of nodes in the tree, so with this upper bound, it has an optimal worst case for any operation.
They are always balanced, by following these rules:
  
          - every node has a color, either red or black;
          - the root is always black;
          - there are no 2 adjiacent red nodes;
          - all leaves are black nodes;
          - every path from a node to its descendants has the same number of black nodes;
- **B-Tree**
- **B+-Tree**
- **Segment tree**
