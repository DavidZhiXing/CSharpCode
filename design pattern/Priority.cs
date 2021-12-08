// define a priority queue

public class PriorityQueue<T>
{
    private List<T> data;
    private IComparer<T> comparer;

    public PriorityQueue()
    {
        data = new List<T>();
    }

    public PriorityQueue(IComparer<T> comparer)
    {
        data = new List<T>();
        this.comparer = comparer;
    }

    public void Enqueue(T item)
    {
        data.Add(item);
        int ci = data.Count - 1; // child index; start at end
        while (ci > 0)
        {
            int pi = (ci - 1) / 2; // parent index
            if (comparer.Compare(data[ci], data[pi]) > 0)
            {
                T tmp = data[ci]; data[ci] = data[pi]; data[pi] = tmp;
                ci = pi;
            }
            else break;
        }
    }

    public T Dequeue()
    {
        // assumes pq is not empty; up to calling code
        int li = data.Count - 1; // last index (before removal)
        T frontItem = data[0];   // fetch the front
        data[0] = data[li];
        data.RemoveAt(li);

        --li; // last index (after removal)
        int pi = 0; // parent index. start at front of pq
        while (true)
        {
            int ci = pi * 2 + 1; // left child index of parent
            if (ci > li) break;  // no children so done
            int rc = ci + 1;     // right child
            if (rc <= li && comparer.Compare(data[rc], data[ci]) < 0) // if there is a rc (ci + 1), and it is smaller than left child, use the rc instead
                ci = rc;
            if (comparer.Compare(data[pi], data[ci]) < 0)
            {
                T tmp = data[pi]; data[pi] = data[ci]; data[ci] = tmp;
                pi = ci;
            }
            else break;
        }
        return frontItem;
    }

    public T Peek()
    {
        T frontItem = data[0];
        return frontItem;
    }

    public int Count()
    {
        return data.Count;
    }

    public override string ToString()
    {
        string s = "";
        for (int i = 0; i < data.Count; ++i)
            s += data[i].ToString() + " ";
        s += "count = " + data.Count;
        return s;
    }

    public bool IsConsistent()
    {
        // is the heap property true for all data?
        if (data.Count == 0) return true;
        int li = data.Count - 1; // last index
        for (int pi = 0; pi < data.Count; ++pi)
        {
            int lci = 2 * pi + 1; // left child index
            int rci = 2 * pi + 2; // right child index

            if (lci <= li && comparer.Compare(data[pi], data[lci]) > 0) return false;
            if (rci <= li && comparer.Compare(data[pi], data[rci]) > 0) return false;
        }
        return true; // passed all checks
    } // IsConsistent

} // PriorityQueue

public class PriorityQueueTest
{
    public static void Test()
    {
        PriorityQueue<int> pq = new PriorityQueue<int>();
        pq.Enqueue(5);
        pq.Enqueue(1);
        pq.Enqueue(3);
        pq.Enqueue(2);
        pq.Enqueue(4);
        Console.WriteLine(pq.Peek());
        Console.WriteLine(pq.Dequeue());
        Console.WriteLine(pq.Dequeue());
        Console.WriteLine(pq.Dequeue());
        Console.WriteLine(pq.Dequeue());
        Console.WriteLine(pq.Dequeue());
        Console.WriteLine(pq.Count());
    }
}