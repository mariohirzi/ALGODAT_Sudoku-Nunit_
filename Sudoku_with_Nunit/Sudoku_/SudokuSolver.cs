using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_
{
    public class SudokuSolver : IVisitor<bool>
    {
        public SudokuSolver()
        {
            this.sudokuRules = new SudokuRules();
        }

        private SudokuRules sudokuRules;

        /// <summary>
        /// Method to solve the classic Sudoku.
        /// </summary>
        /// <param name="sudokuClassic"></param>
        /// <returns></returns>
        public bool Visit(SudokuClassic sudokuClassic)
        {
            bool backstep = false;

            for (int i = 0; i < sudokuClassic.SudokuFields.Count; i++)
            {
                // Checks if the sudoku is solvable.
                if (i == -1)
                {
                    return false;
                }

                // Checks if this field is changeable.
                if (!sudokuClassic.SudokuFields[i].GivenNumber)
                {
                    do
                    {
                        // Checks if the number is 9.
                        // If true, the number is set to 0 and the backspace process is initiated.
                        if (sudokuClassic.SudokuFields[i].Number == 9)
                        {

                            sudokuClassic.SudokuFields[i].Number = 0;
                            i-=2;
                            backstep = true;
                            break;
                        }

                        sudokuClassic.SudokuFields[i].Number++;
                        backstep = false;

                        // Checks whether the rules are followed.
                    } while (!this.sudokuRules.CheckRules(sudokuClassic, sudokuClassic.SudokuFields[i]));
                }
                else
                {
                    // Part of the backstep process.
                    if (backstep)
                    {
                        i -= 2;
                    }
                }
            }

            return true;
        }
    }
}
