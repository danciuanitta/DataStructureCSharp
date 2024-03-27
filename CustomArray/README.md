# Arrays
An ordered (not necessarily sorted) and finite collection of items of same type stored sequencially in memory (contiguous memory location or adjiacent memory location). An array element consists of 2 items: the value stored and its index. 
It uses 0-based indexing.
Finding an element in an array is an easy operation, because you simply add an 'offset' to the base value (location of first element => where index = 0). The location of the next element depends on the data type stored in the array.


Operations and Big-O:
- insert at the end: O(1) (if size < capacity)
- insert at specific index: O(n)
- access element at certain index: O(1)
- search in array: O(n)
- search in sorted array: O(logn)
