# Stack
It is a special kind of data structure, which follows LIFO (Last-In First-Out) principle, where the last item added to the collection is the first one to be removed (imagine pile of plates).

It can be implemented in 2 ways:
- using circular arrays
- using linked-list


Operations:
- *push* - adding element to the collection (at the end of the collection)
- *pop* - removing first element of the collection
- *peek* - access first element



In .NET, Stack\<T\>  is implemented using a circular array, as per Microsoft [documentation](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=net-8.0)

Stacks and queues are useful when you need temporary storage. 
Use Queue if you need to access the information in the same order that it is stored in the collection, use Stack if you need to access the information in reverse order.

Useful for reverse operations.
