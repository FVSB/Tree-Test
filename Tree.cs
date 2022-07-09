using System;
using System.Collections;

public class Queue<T> : IQueue<T>
{
    private LinkedList<T> temp = new LinkedList<T>() { };
    public Queue(T hola)
    {
        temp.AddFirst(hola);
    }
    public T Front { get { return temp.First.Value; } }

    public int Count => temp.Count;

    public void Clear()
    {
        temp.Clear();
    }

    public void Pop()
    {
        temp.RemoveFirst();
    }

    public void Push(T item)
    {
        temp.AddLast(item);
    }
}


public class Tree<T>
{
    public T Value { get; set; }

    public List<Tree<T>> Children { get; set; }

    public Tree(T Value, List<Tree<T>> Children)
    {
        this.Value = Value;
        this.Children = Children;
    }

    public void AddChildren(Tree<T> Value)
    {
        Children.Add(Value);
    }

    public bool SearchBfS(T Value)
    {
        foreach (var item in Search<T>.BFS(this))
        {
            if (item.Value.Equals(Value))
            {
                return true;
            }
        }
        return false;
    }

    public bool Dfs(T value)
    {

        if (this.Value.Equals(value))
        {
            return true;
        }


        foreach (var item in this.Children)
        {
            if (item.Dfs(value)) return true;
        }


        return false;

    }

    public bool DFS(T value)
    {
        foreach (var item in Search<T>.DFS(this))
        {
            if (item.Value.Equals(value))
            {
                return true;
            }
        }
        return false;
    }
}




public static class Search<T>
{
    public static IEnumerable<Tree<T>> BFS(Tree<T> root)
    {
        Queue<Tree<T>> q = new Queue<Tree<T>>(root);

        while (q.Count > 0)
        {
            yield return q.Front;
            foreach (var item in q.Front.Children)
            {
                q.Push(item);

            }
            q.Pop();
        }
    }


    public static IEnumerable<Tree<T>> DFS(Tree<T> root)
    {
        Stack<Tree<T>> s = new Stack<Tree<T>>();
        s.Push(root);
        while (s.Count > 0)
        {
            yield return s.Peek();
            foreach (var item in s.Pop().Children)
            {
                s.Push(item);
            }
        }
    }






}