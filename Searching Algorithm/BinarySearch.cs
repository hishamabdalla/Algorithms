namespace BinarySearch
{
    internal class Program
    {
        static int  BinarySearch(int[]arr,int l,int h,int key)
        {
            while (l<=h)
            {
                int m = (l + h) / 2;
                if (arr[m] == key)
                {
                    return m;
                }
                else if (arr[m] > key)
                {
                    h = m - 1;
                }
                else
                {
                    l= m + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Sort Numbers:");
            string[] input = Console.ReadLine().Split(" ");

            int size = input.Length;

            int[]arr = new int[size];
            Console.WriteLine("Enter the Integer: ");
            int key=int.Parse(Console.ReadLine());

            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int Result=BinarySearch(arr, 0, arr.Length-1,key);

            if (Result == -1)
            {
                Console.WriteLine($"The Number : ( {key} ) Was Not Found.");
            }
            else
            {
                Console.WriteLine($"The Number: ( {arr[Result]} ) Was Found in Index ( {Result} )");
            }

        }
    }
}
