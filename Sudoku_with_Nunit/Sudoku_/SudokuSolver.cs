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

        public bool Visit(SudokuClassic sudokuClassic)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();



            bool backstep = false;

            for (int i = 0; i < sudokuClassic.SudokuFields.Count; i++)
            {

                if (!sudokuClassic.SudokuFields[i].GivenNumber)
                {
                    do
                    {
                        if (sudokuClassic.SudokuFields[i].Number == 9)
                        {
                            if (i == 2)
                            {
                                throw new Exception();
                            }
                            sudokuClassic.SudokuFields[i].Number = 0;
                            i-=2;
                            backstep = true;
                            break;
                        }
                        sudokuClassic.SudokuFields[i].Number++;
                        backstep = false;
                    } while (!this.sudokuRules.CheckRules(sudokuClassic, sudokuClassic.SudokuFields[i]));
                }
                else
                {
                    if (backstep)
                    {
                        i -= 2;
                    }
                }
            }

            stopwatch.Stop();

            var stopTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine(stopTime);

            return true;
        }
    }
}
