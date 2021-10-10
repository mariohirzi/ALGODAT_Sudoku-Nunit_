using NUnit.Framework;
using Sudoku_;

namespace NUnitTest
{
    public class Tests
    {
        private Sudoku sudoku;

        [SetUp]
        public void Setup()
        {
            sudoku = new Sudoku();
        }

        [Test]
        public void Test1()
        {
            string su = "530070000600195000098000060800060003400803001700020006060000280000419005000080079";

            string correctSu = "534678912672195348198342567859761423426853791713924856961537284287419635345286179";

            SudokuAbstract result = sudoku.Solve(su);

            string resultInString = ConvertSudokuToString(result);

            if (correctSu == resultInString)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]
        public void Test2()
        {
            string su = "410065007" +
                        "006007480" +
                        "207490006" +
                        "060070100" +
                        "301500072" +
                        "090042308" +
                        "108600029" +
                        "020018640" +
                        "600300010";

            string correctSu = "413865297" +
                        "956237481" +
                        "287491536" +
                        "862973154" +
                        "341586972" +
                        "795142368" +
                        "138654729" +
                        "529718643" +
                        "674329815";

            SudokuAbstract result = sudoku.Solve(su);

            string resultInString = ConvertSudokuToString(result);

            if (correctSu == resultInString)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        public string ConvertSudokuToString(SudokuAbstract temp)
        {
            string result = string.Empty;

            foreach (var element in temp.SudokuFields)
            {
                result += element.Number.ToString();
            }

            return result;
        }
    }
}