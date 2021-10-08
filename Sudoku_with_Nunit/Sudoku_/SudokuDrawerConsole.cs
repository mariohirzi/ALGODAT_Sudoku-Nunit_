using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_
{
    class SudokuDrawerConsole : IDrawer
    {
        public void WriteSudoku(List<SudokuField> sudokuFields)
        {
            foreach (var element in sudokuFields)
            {
                Console.SetCursorPosition(element.Positions.X * 2, (element.Positions.Y * 2) +10);

                ConsoleColor oldColor = Console.ForegroundColor;

                if (!element.GivenNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.Write(element.Number);

                if (!element.GivenNumber)
                {
                    Console.ForegroundColor = oldColor;
                }
            }
        }

        public void WriteUnsolvableSudoku()
        {
            Console.WriteLine("Unsolvable Sudoku!");
        }
    }
}
