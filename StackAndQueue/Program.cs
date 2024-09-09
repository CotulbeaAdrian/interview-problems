namespace StackAndQueue;

class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine("Dequeue:" + queue.Dequeue());
        Console.WriteLine("Dequeue:" + queue.Dequeue());

        queue.Enqueue(1);

        Console.WriteLine("Dequeue:" + queue.Dequeue());
        Console.WriteLine("Dequeue:" + queue.Dequeue());
    }
}