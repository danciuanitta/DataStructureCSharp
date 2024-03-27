# Queue
It is a special kind of data structure, which follows FIFO (First-In First-Out) principle, where the first item added to the collection is also the first one to be removed (imagine a line/queue at grocery).

It can be implemented in 2 ways:
- using circular arrays
- using linked-list


Operations:
- *enqueue* - adding element to the collection (at the end of the collection)
- *dequeue* - removing first element of the collection
- *peek* - access first element



In .NET, Queue\<T\>  is implemented using a circular array, as per Microsoft [documentation](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=net-8.0)
