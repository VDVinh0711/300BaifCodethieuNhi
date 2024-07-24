namespace Dao_Nguoc_Mang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 5, 65, 6, 7 };

            int right = ints.Length-1;
            int left = 0;
          
            while (left <= right)
            {
                int temp = ints[left];
                ints[left] = ints[right];
                ints[right] = temp;
                left++;
                right--;
            }
            for(int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }


       
            


        }
        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            } 
    }
}
