using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidSodoku
{
    internal class Program
    {
        public static bool IsValidSudoku(char[][] board) {
            HashSet<char>[] rows = new HashSet<char>[9];
            HashSet<char>[] cols = new HashSet<char>[9];
            HashSet<char>[] boxes = new HashSet<char>[9];
            for (int i = 0; i < 9; i++)
            {
                rows[i] = new HashSet<char>();
                cols[i] = new HashSet<char>();
                boxes[i] = new HashSet<char>();
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char current_val = board[i][j];
                    if (current_val != '.')
                    {
                        int boxIndex = (i / 3) * 3 + j / 3;
                        if (rows[i].Contains(current_val) || cols[j].Contains(current_val) || boxes[boxIndex].Contains(current_val))  return false;
                        rows[i].Add(current_val);
                        cols[j].Add(current_val);
                        boxes[boxIndex].Add(current_val);
                    }
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            char[][] board = new char[][]
            {
                new char[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '2', '.', '.', '.', '.', '6', '.' },
                new char[] { '5', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

           Console.Write(IsValidSudoku(board)); 

        }
    }
}