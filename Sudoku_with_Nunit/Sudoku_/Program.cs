using System;

namespace Sudoku_
{
    class Program
    {
        static void Main(string[] args)
        {
            Sudoku sudoku = new Sudoku();
            IDrawer drawer = new SudokuDrawerConsole();



            SudokuAbstract FinishedSudoku = sudoku.Solve(args[0]);



            if (!(FinishedSudoku.Solvable))
            {
                drawer.WriteSudoku(FinishedSudoku.SudokuFields);
            }
            else
            {
                drawer.WriteUnsolvableSudoku();
            }



            Console.ReadKey();
        }
    }
}
