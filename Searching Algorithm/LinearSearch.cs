namespace linear_Search
{
    internal class Program
    {
        public static int LinearSearch(int[] arr,int size,int num)
        {
            for (int i = 0; i < num; i++)
            {
                if (arr[i] == num)
                {
                    return i;
                    
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter The Numbers Of Array: ");
            string[] arr =Console.ReadLine().Split(" ");

            int Size = arr.Length;

            int[] arrOfNum = new int[Size];
            
            for (int i = 0;i < arr.Length;i++)
            {
                arrOfNum[i] = int.Parse(arr[i]);
            }
            Console.WriteLine("Enter the integer");
            int Num = int.Parse(Console.ReadLine());

            int Result = LinearSearch(arrOfNum, Size, Num);

           if(Result == -1) 
           {
                Console.WriteLine($"The Number : ( {Num} ) Was Not Found.");
           }

           else
           {
                Console.WriteLine($"The Number : ( {arrOfNum[Result]} ) Was  Found in index ( {Result} )");
           }
        }
    }
}
