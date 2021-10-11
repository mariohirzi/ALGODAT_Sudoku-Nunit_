using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku_
{
    public abstract class SudokuAbstract : IVisitable
    {
        public SudokuAbstract(List<SudokuField> sudokuFields)
        {
            this.SudokuFields = sudokuFields;
        }

        public bool Solvable
        {
            get;
            set;
        }

        public List<SudokuField> SudokuFields
        {
            get;
            set;
        }

        /// <summary>
        /// The accept method.
        /// </summary>
        /// <typeparam name="T">The placeholder for the return data type.</typeparam>
        /// <param name="visitor">The visitor class.</param>
        /// <returns>Returns t for the placeholder.</returns>
        public abstract T Accept<T>(IVisitor<T> visitor);
    }
}