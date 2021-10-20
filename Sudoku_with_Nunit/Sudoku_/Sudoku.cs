using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_
{
    public class Sudoku
    {

        private SudokuAbstract sudokuType;

        private SudokuSolver sudokuSolver;


        public SudokuAbstract Solve(string input)
        {
            List<SudokuField> sudokuFields = this.InputPreparationNumberLine(input);
            this.sudokuType = new SudokuClassic(sudokuFields);
            this.sudokuSolver = new SudokuSolver();

            if (!this.CheckInput(sudokuType))
            {
                this.sudokuType.Solvable = false;
                return sudokuType;
            }

            // Sudoku solve process.
            if (!this.sudokuType.Accept(sudokuSolver))
            {
                this.sudokuType.Solvable = false;
                return sudokuType;
            }

            this.sudokuType.Solvable = true;
            return this.sudokuType;
        }

        private bool CheckInput(SudokuAbstract sudoku)
        {
            if (sudoku.SudokuFields.Count != 81)
            {
                return false;
            }

            return true;
        }

        private List<SudokuField> InputPreparationNumberLine(string input)
        {
            List<SudokuField> sudokuFields = new List<SudokuField>();

            int counterRow = 0;
            int counterColumn = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber;

                if (!Int32.TryParse(input[i].ToString(), out currentNumber))
                {
                    Console.WriteLine("Wrong Input");
                }

                if (Math.Sqrt(input.Length) == counterColumn)
                {
                    counterColumn = 0;
                    counterRow++;

                    sudokuFields.Add(new SudokuField(new PositionXY(counterColumn, counterRow), currentNumber));

                    counterColumn++;
                    continue;
                }

                sudokuFields.Add(new SudokuField(new PositionXY(counterColumn, counterRow), currentNumber));
                counterColumn++;

            }

            return sudokuFields;
        }



        private List<SudokuField> InputPreparationLine(string[] input)
        {
            List<SudokuField> sudokuFields = new List<SudokuField>();

            int counterRow = 0;
            int counterColumn = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber;

                if (!Int32.TryParse(input[i][0].ToString(), out currentNumber))
                {
                    Console.WriteLine("Wrong Input");
                }

                if (Math.Sqrt(input.Length) == counterColumn)
                {
                    counterColumn = 0;
                    counterRow++;

                    sudokuFields.Add(new SudokuField(new PositionXY(counterColumn, counterRow), currentNumber));

                    counterColumn++;
                    continue;
                }

                sudokuFields.Add(new SudokuField(new PositionXY(counterColumn, counterRow), currentNumber));
                counterColumn++;

            }

            return sudokuFields;
        }

        private List<SudokuField> InputPreparation9x9Form(string[] input)
        {
            List<SudokuField> sudokuFields = new List<SudokuField>();

            int counterRow = 0;
            int counterColumn = 0;

            for (int i = 0; i < input.Length; i++)
            {

                int currentNumber;

                if (!Int32.TryParse(input[i][0].ToString(), out currentNumber))
                {
                    Console.WriteLine("Wrong Input");
                }

                sudokuFields.Add(new SudokuField(new PositionXY(counterColumn, counterRow), currentNumber));
                counterColumn++;
                

                if (input[i].Contains("\r"))
                {
                    int temp = 0;

                    char temp1 = input[i][3];
                    if (!Int32.TryParse(input[i][3].ToString(), out temp))
                    {
                        Console.WriteLine("Wrong Input");
                    }

                    counterColumn = 0;
                    counterRow++;

                    sudokuFields.Add(new SudokuField(new PositionXY(counterColumn, counterRow), temp));

                    counterColumn++;

                }
            }

            return sudokuFields;
        }
    }
}
