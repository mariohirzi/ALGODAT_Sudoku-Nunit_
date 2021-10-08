using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_
{
    public class SudokuField
    {
        public SudokuField(PositionXY positions, int number)
        {
            this.Positions = positions;
            this.Number = number;

            if (number == 0)
            {
                this.GivenNumber = false;
            }
            else
            {
                this.GivenNumber = true;
            }
        }

        public bool GivenNumber
        {
            get;
            private set;
        }

        public PositionXY Positions
        {
            get;
            set;
        }

        public int Number
        {
            get;
            set;
        }
    }
}
