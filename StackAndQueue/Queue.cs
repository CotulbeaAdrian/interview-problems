namespace StackAndQueue;

public class Queue
{
    public Stack s1 = new Stack();
    public Stack s2 = new Stack();

    public void Enqueue(int value)
    {
        s1.Push(value);
    }

    public int Dequeue()
    {
        if (s2.Count() == 0)
        {
            while (s1.Count() > 0)
            {
                s2.Push(s1.Pop());
            }
        }

        return s2.Pop();
    }
}
