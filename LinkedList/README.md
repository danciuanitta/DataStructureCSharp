# Single-Linked List
A linear data structure consisting of a sequence of items, where each element of list (called *node*) contains the *value* to be stored and a refference to the *next* element of the list.
The elements are not stored in contiguous memory locations, but each points to the address of the next one. Traversing is always done forward. 
The first element is called *head* and the last one is called *tail*, having the next set to null.

Operations and Big-O:
- access element: O(n)
- insert at the begining or after given node: O(1)
- insert at the end: O(n) (could be impoved by holding a refference in the implementation to the last item, too)
