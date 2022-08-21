using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Checker
    {
        public static bool Checkers(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (horizontal(board) || vertical(board) || mainDiagonal(board) || secondaryDiagnoal(board))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static int sum(int[] counter)
        {
            int count = 0;
            for (int i = 0; i < counter.Length; i++)
            {
                count += counter[i];
            }
            return count;
        }

        public static bool horizontal(string[,] board)
        {
            int[] counter = new int[board.GetLength(0)];
            for (int i = 0; i < board.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == board[i + 1, j])
                    {
                        counter[i]++;
                    }
                }
            }
            if (sum(counter) == board.GetLength(0) - 1)
            {
                return true;
            }
            return false;
        }

        public static bool vertical(string[,] board)
        {
            int[] counter = new int[board.GetLength(0)];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1) - 1; j++)
                {
                    if (board[i, j] == board[i, j + 1])
                    {
                        counter[i]++;
                    }
                }
            }
            if (sum(counter) == board.GetLength(0) - 1)
            {
                return true;
            }
            return false;
        }

        public static bool mainDiagonal(string[,] board)
        {
            //main diagnoal
            int[] counter = new int[board.GetLength(0)];
            for (int i = 0; i < board.GetLength(0) - 1; i++)
            {
                if (board[i, i] == board[i + 1, i + 1])
                {
                    counter[i]++;
                }
            }
            if (sum(counter) == board.GetLength(0) - 1)
            {
                return true;
            }
            return false;
        }

        public static bool secondaryDiagnoal(string[,] board)
        {
            //secondary diagnoal
            int[] counter = new int[board.GetLength(0)];
            for (int i = 0; i < board.GetLength(0) - 1; i++)
            {
                for (int j = board.GetLength(1) - 1; j > 0; j--)
                {
                    if (board[i, j] == board[i + 1, j - 1])
                    {
                        counter[i]++;
                    }
                }

            }
            if (sum(counter) == board.GetLength(0) - 1)
            {
                return true;
            }
            return false;
        }
    }
}





