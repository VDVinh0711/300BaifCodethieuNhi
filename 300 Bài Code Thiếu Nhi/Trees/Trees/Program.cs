using System;
using System.Security.Policy;

namespace Trees
{
     public class TreeNode {
        public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
                 this.val = val;
                 this.left = left;
                 this.right = right;
             }
     }
     
     
     
    internal class Program
    {
        public static void ShowTrees(TreeNode root)
        {
            if(root == null) return;
            Console.WriteLine(root.val);
            ShowTrees(root.left);
            ShowTrees(root.right);
        }
        
        public static int MaxDepth( TreeNode root)
        {
            if (root == null) return 0;
            int leftLength = MaxDepth(root.left);
            int rightLength = MaxDepth(root.right);
            if (leftLength > rightLength)
            {
                return leftLength += 1;
            }
            else
            {
                return rightLength += 1;
            }
        }



        public static bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root,long.MinValue, long.MaxValue);
        }

        public static bool IsValidBST(TreeNode root, long minvalue, long maxvalue)
        {
            if (root == null) return true;
            if (root.val >= maxvalue || root.val <= minvalue) return false;
            return IsValidBST(root.left, minvalue, root.val) && IsValidBST(root.right, root.val, maxvalue);
        }
        
        
        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.right = new TreeNode(3);


            TreeNode root2 = new TreeNode(5);
            root2.left = new TreeNode(1);
            root2.right = new TreeNode(4);
            root2.right.left = new TreeNode(3);
            root2.right.right = new TreeNode(6);
         
            
            Console.WriteLine("Result " +  IsValidBST( root));
            Console.WriteLine("Result2" + IsValidBST(root2));
        }
    }
}