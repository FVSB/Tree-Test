// Defines a collection that stores items following a FIFO pattern
// FIFO: First in, first out
interface IQueue<T>
{
    // Element at the front of the queue
    public T Front { get; }

    // Size of the collection
    public int Count { get; }

    // Adds a new element to the back of the queue
    public void Push(T item);

    // Remove the element at the front of the queue
    public void Pop();

    // Makes the queue empty
    public void Clear();
}