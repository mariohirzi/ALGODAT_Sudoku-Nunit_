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

        [Test]
        public void Test8()
        {
            string su = "004300209005009001070060043006002087190007400050083000600000105003508690042910300";

            string correctSu = "864371259325849761971265843436192587198657432257483916689734125713528694542916378";

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
        public void Test9()
        {
            string su = "040100050107003960520008000000000017000906800803050620090060543600080700250097100";

            string correctSu = "346179258187523964529648371965832417472916835813754629798261543631485792254397186";

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
        public void Test10()
        {
            string su = "600120384008459072000006005000264030070080006940003000310000050089700000502000190";

            string correctSu = "695127384138459672724836915851264739273981546946573821317692458489715263562348197";

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
        public void Test11()
        {
            string su = "497200000100400005000016098620300040300900000001072600002005870000600004530097061";

            string correctSu = "497258316186439725253716498629381547375964182841572639962145873718623954534897261";

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
        public void Test12()
        {
            string su = "005910308009403060027500100030000201000820007006007004000080000640150700890000420";

            string correctSu = "465912378189473562327568149738645291954821637216397854573284916642159783891736425";

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
        public void Test13()
        {
            string su = "100005007380900000600000480820001075040760020069002001005039004000020100000046352";

            string correctSu = "194685237382974516657213489823491675541768923769352841215839764436527198978146352";

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
        public void Test14()
        {
            string su = "009065430007000800600108020003090002501403960804000100030509007056080000070240090";

            string correctSu = "289765431317924856645138729763891542521473968894652173432519687956387214178246395";

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
        public void Test15()
        {
            string su = "000000657702400100350006000500020009210300500047109008008760090900502030030018206";

            string correctSu = "894231657762495183351876942583624719219387564647159328128763495976542831435918276";

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
        public void Test16()
        {
            string su = "503070190000006750047190600400038000950200300000010072000804001300001860086720005";

            string correctSu = "563472198219386754847195623472638519951247386638519472795864231324951867186723945";

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
        public void Test17()
        {
            string su = "060720908084003001700100065900008000071060000002010034000200706030049800215000090";

            string correctSu = "163725948584693271729184365946358127371462589852917634498231756637549812215876493";

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
        public void Test18()
        {
            string su = "004083002051004300000096710120800006040000500830607900060309040007000205090050803";

            string correctSu = "974183652651274389283596714129835476746912538835647921568329147317468295492751863";

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
        public void Test19()
        {
            string su = "000060280709001000860320074900040510007190340003006002002970000300800905500000021";

            string correctSu = "431567289729481653865329174986243517257198346143756892612975438374812965598634721";

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
        public void Test20()
        {
            string su = "004300000890200670700900050500008140070032060600001308001750900005040012980006005";

            string correctSu = "254367891893215674716984253532698147178432569649571328421753986365849712987126435";

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