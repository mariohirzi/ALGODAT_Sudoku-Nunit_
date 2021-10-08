using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_
{
    public class SudokuRules
    {
        public bool CheckRules(SudokuClassic sudokuClassic, SudokuField sudokuField)
        {
            if (this.CheckRowsAndColumns(sudokuClassic, sudokuField) && this.Check3x3Field(sudokuClassic, sudokuField))
            {
                return true;
            }

            return false;
        }

        private bool CheckRowsAndColumns(SudokuClassic sudokuClassic, SudokuField sudokuField)
        {
            foreach (var element in sudokuClassic.SudokuFields)
            {
                if (element == sudokuField)
                {
                    continue;
                }

                if ((element.Positions.X == sudokuField.Positions.X || element.Positions.Y == sudokuField.Positions.Y) && element.Number == sudokuField.Number)
                {
                    return false;
                }
            }

            return true;
        }

        private bool Check3x3Field(SudokuClassic sudokuClassic, SudokuField sudokuField)
        {
            foreach (var element in sudokuClassic.SudokuFields)
            {
                if (element == sudokuField)
                {
                    continue;
                }

                if ((Math.Ceiling(Convert.ToDouble(element.Positions.X / 3)) == Math.Ceiling(Convert.ToDouble(sudokuField.Positions.X / 3))) &&
                    (Math.Ceiling(Convert.ToDouble(element.Positions.Y / 3)) == Math.Ceiling(Convert.ToDouble(sudokuField.Positions.Y / 3))))
                {
                    if (element.Number == sudokuField.Number)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
