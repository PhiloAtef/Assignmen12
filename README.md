# Table Comparison
| Collection                | Structure                     | Access            | Insertion at End    | Insertion/Deletion at Start/Middle | Search             |
|---------------------------|-------------------------------|-------------------|---------------------|------------------------------------|--------------------|
| Hashset                   | Hash-based collection of unique elements| O(1)              | O(1)                | O(1) on average, O(n) in the worst case if a resize or rehashing operation is necessary | O(1) on average, O(n) in the worst case due to hash collisions. |
| Hashtable                 | Key/value pairs (non-generic) | O(1) avg, O(n) worst | O(1) avg, O(n) worst | O(1) avg, O(n) worst                | O(1) avg, O(n) worst |
| Dictionary<TKey, TValue>  | Key/value pairs (generic)     | O(1) avg, O(n) worst | O(1) avg, O(n) worst | O(1) avg, O(n) worst                | O(1) avg, O(n) worst |
| List<T>                   | Dynamic array (generic)       | O(1)              | O(1), O(n) if capacity reached      | O(n)                               | O(n)               |
| LinkedList<T>             | Doubly linked list            | O(n)              | O(1)                | O(1)                               | O(n)               |
| ArrayList                 | Dynamic array (non-generic)   | O(1)              | O(1), O(n) if capacity reached      | O(n)                               | O(n)               |
| Stack<T>                  | LIFO array                    | O(1)              | O(1)                | N/A                                | N/A                |
| Queue<T>                  | FIFO array                    | O(1)              | O(1)                | N/A                                | N/A                |

# When to Use Each Collection

## ArrayList 
- Used for collections that may contain different types. However, it is recommended to use generic List<T> for type safety. Example: A collection of various data types.

## List<T>
- Suitable for situations where frequent access to elements by index is required. Example: Maintaining a list of customer records.

## LinkedList<T>
-  Best for scenarios where frequent insertions and deletions are required. Example: Implementing an undo feature in software.

## Stack<T>
- To have a collection that implements Last in First out (LIFO)

## Queue<T>
- Suitable for scenarios requiring order preservation. Example: Print job scheduling.

## Dictionary<TKey, TValue>
- Suitable for collections requiring quick access by key. Example: Employee details lookup.

## Hashtable
- Useful for fast lookups and inserts based on keys. Example: Storing configurations or settings.

## Hashset
- Best for maintaining unique items and quick membership tests. Example: Maintaining a list of unique usernames.
