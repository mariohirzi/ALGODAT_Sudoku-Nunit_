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

            if (correctSu == resultInString || result.Solvable)
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

            if (correctSu == resultInString || result.Solvable)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]
        public void Test3()
        {
            string su = "009028700806004005003000004600000000020713450000000002300000500900400807001250300";



            SudokuAbstract result = sudoku.Solve(su);

            if (!result.Solvable)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]
        public void Test4()
        {
            string su = "009070005002100900100028000070005001008510000050000300000003006800000000210000087";



            SudokuAbstract result = sudoku.Solve(su);

            if (!result.Solvable)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]
        public void Test5()
        {
            string su = "002030008000008000031020000060050270010000050204060031000080605000000013005310400";

            string correctSu = "672435198549178362831629547368951274917243856254867931193784625486592713725316489";

            SudokuAbstract result = sudoku.Solve(su);

            string resultInString = ConvertSudokuToString(result);

            if (correctSu == resultInString || result.Solvable)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]
        public void Test6()
        {
            string su = "305420810487901506029056374850793041613208957074065280241309065508670192096512408";

            string correctSu = "365427819487931526129856374852793641613248957974165283241389765538674192796512438";

            SudokuAbstract result = sudoku.Solve(su);

            string resultInString = ConvertSudokuToString(result);

            if (correctSu == resultInString || result.Solvable)
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }

        [Test]
        public void Test7()
        {
            string su = "256489173374615982981723456593274861712806549468591327635147298127958634849362715";

            string correctSu = "256489173374615982981723456593274861712836549468591327635147298127958634849362715";

            SudokuAbstract result = sudoku.Solve(su);

            string resultInString = ConvertSudokuToString(result);

            if (correctSu == resultInString || result.Solvable)
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