using System;



// Input [1,2,-5,6,5,9]
//Output 5  
// Input [1,2,-6,10,9]
//output -1;
namespace Code_Thieu_Nhi
{
    internal class Program
    {
        static int Maxnumber(int[] n)
        {
            int resutl = -1;
            if (n.Length == 0) return resutl;
            for(int i=0;i<n.Length;i++)
            {
                if (n[i] > resutl && SearchOpposite(n, -n[i]))
                {
                    resutl = n[i];
                }
            }
            return resutl;
        }

        static int Maxnumberv2(int[] n)
        {
            int resutl = -1;
            List<int> list = new List<int>();
           
            list = n.ToList();
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > resutl && list.Contains(-n[i]))
                {
                    resutl = n[i];
                }
            }
            return resutl;
        }
        static bool SearchOpposite(int[] n , int numberserch)
        {
            for(int i =0; i < n.Length; i++)
            {
                if (n[i] != numberserch) continue;
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] arrr = { 1, 2, -9, 10, 9};
            Console.WriteLine(Maxnumberv2(arrr));

        }
    }
}