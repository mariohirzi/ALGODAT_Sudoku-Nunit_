using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_
{
    /// <summary>
    /// This is the visit able interface.
    /// </summary>
    public interface IVisitable
    {
        /// <summary>
        /// Method to accept a visitor.
        /// </summary>
        /// <typeparam name="T">The placeholder for the return data type.</typeparam>
        /// <param name="visitor">The class which is visiting.</param>
        /// <returns>Returns t for the placeholder.</returns>
        T Accept<T>(IVisitor<T> visitor);
    }
}
