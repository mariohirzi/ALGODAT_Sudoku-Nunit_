using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_
{
    public interface IDrawer
    {
        void WriteSudoku(List<SudokuField> sudokuFields);
        void WriteUnsolvableSudoku();
    }
}
