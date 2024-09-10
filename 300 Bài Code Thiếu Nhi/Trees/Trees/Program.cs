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
        
        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(-8);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            ShowTrees(root);
            
            Console.WriteLine("DeepLegnth " +  MaxDepth( root));
        }
    }
}