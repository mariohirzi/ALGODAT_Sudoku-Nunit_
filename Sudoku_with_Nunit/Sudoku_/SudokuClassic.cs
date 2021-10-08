using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku_
{
    public class SudokuClassic : SudokuAbstract
    {
        public SudokuClassic(List<SudokuField> sudokuFields) : base(sudokuFields)
        {
        }

        /// <summary>
        /// The accept method.
        /// </summary>
        /// <typeparam name="T">The placeholder for the return data type.</typeparam>
        /// <param name="visitor">The visitor class.</param>
        /// <returns>Returns t for the placeholder.</returns>
        public override T Accept<T>(IVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}