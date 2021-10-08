namespace Sudoku_
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    /// <summary>
    /// This is the visitor interface.
    /// </summary>
    /// <typeparam name="T">T is used as a placeholder for the return data type.</typeparam>
    public interface IVisitor<T>
    {
        /// <summary>
        /// Method to visit the sudoku classic game.
        /// </summary>
        /// <param name="sudokuClassic">The sudoku game which gets visited.</param>
        /// <returns>Returns some data type.</returns>
        T Visit(SudokuClassic sudokuClassic);
    }
}
