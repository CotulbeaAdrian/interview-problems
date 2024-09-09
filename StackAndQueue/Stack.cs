namespace StackAndQueue;

public class Stack
{
    private List<int> elements = new List<int>();

    public void Push(int value)
    {
        elements.Add(value);
    }

    public int Pop()
    {
        if (elements.Count == 0)
        {
            Console.WriteLine("Empty stack");
        }

        int value = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);

        return value;
    }

    public int Count()
    {
        return elements.Count;
    }
}