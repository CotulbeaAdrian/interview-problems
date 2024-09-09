namespace SumOfMax;

public class Program
{
    static void Main(string[] args)
    {
        int sum = SumOfMax([3,2]);
        Console.WriteLine(sum);
    }

   static int SumOfMax(int[] arr)
    {
        int sum = 0;

        if(arr.Length == 1) return arr[0];

        if (arr[0] > arr[1]) { sum += arr[0];}

        if (arr[arr.Length - 1] > arr[arr.Length - 2]) { sum += arr[arr.Length - 1]; }

        for (int i = 1; i < arr.Length-1; i++)
        {
            if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
            {
                sum += arr[i];
                i++;
            }
        }

        return sum;
    }
}
