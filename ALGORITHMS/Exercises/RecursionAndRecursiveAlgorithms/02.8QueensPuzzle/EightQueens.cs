﻿using System;
using System.Collections.Generic;

namespace _02._8QueensPuzzle
{
    class EightQueens
    {
        const int Size = 8;
        static bool[,] chessboard = new bool[Size, Size];

        static int solutionCount = 0;

        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColumns = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();

        static void Main(string[] args)
        {
            PutQueens(0);
            Console.WriteLine(solutionCount);
        }

        static void PutQueens(int row)
        {
            if (row == Size)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAtackedPositions(row, col);
                        PutQueens(row + 1);
                        UnMarkllAtackedPositions(row, col);
                    }
                }
            }
        }

        private static void UnMarkllAtackedPositions(int row, int col)
        {
            attackedRows.Remove(row);
            attackedColumns.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals.Remove(col + row);
            chessboard[row, col] = false;
        }

        private static void MarkAllAtackedPositions(int row, int col)
        {
            attackedRows.Add(row);
            attackedColumns.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRightDiagonals.Add(col + row);
            chessboard[row, col] = true;
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            var positionOccupied =
                attackedRows.Contains(row) ||
                attackedColumns.Contains(col) ||
                attackedLeftDiagonals.Contains(col - row) ||
                attackedRightDiagonals.Contains(col + row);

            return !positionOccupied;
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (chessboard[row, col] == true)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            solutionCount++;
        }
    }
}