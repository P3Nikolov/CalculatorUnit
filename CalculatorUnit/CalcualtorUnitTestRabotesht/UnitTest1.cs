using CalculatorUnit;

namespace CalcualtorUnitTestRabotesht
{
            [TestClass]
            public class UnitTestSumMethod
            {

                //Sum Tests
                [TestMethod]
                public void TestMethodTestSumAdd200andEqual300()
                {
                    double result = 0;
                    Calculator calc = new Calculator();
                    result = calc.Sum(100, 200);

                    Assert.AreEqual(100 + 200, result, "100+200 is not eqaul 300");
                }

                [TestMethod]
                public void TestMethodTestSumNegative200andEqualMinus100()
                {
                    double result = 0;

                    Calculator calc = new Calculator();
                    result = calc.Sum(100, -200);

                    Assert.AreEqual(100 + (-200), result, "100+(-200) is not eqaul -100");
                }

                [TestMethod]
                public void TestMethodTestSumNegative200WithNegative100andEqualMinus100()
                {
                    double result = 0;

                    Calculator calc = new Calculator();
                    result = calc.Sum(-100, -200);

                    Assert.AreEqual(-100 + (-200), result, "-100+(-200) is not eqaul -300");
                }
                //SubstractTests
                [TestMethod]
                public void TestMethodTestSub200With100andEqualMinus100()
                {
                    double result = 0;

                    Calculator calc = new Calculator();
                    result = calc.Sub(100, 200);

                    Assert.AreEqual(100 - 200, result, "100-200 is not eqaul -100");
                }
                [TestMethod]
                public void TestMethodTestSubNegative200With100andEqual100()
                {
                    double result = 0;

                    Calculator calc = new Calculator();
                    result = calc.Sub(100, -200);

                    Assert.AreEqual(100 - (-200), result, "100-(-200) is not eqaul 100");
                }
                [TestMethod]
                public void TestMethodTestSubNegative200WithNegative100andEqualMinus100()
                {
                    double result = 0;

                    Calculator calc = new Calculator();
                    result = calc.Sub(-100, -200);

                    Assert.AreEqual(-100 - (-200), result, "-100-(-200) is not eqaul -300");
                }
                //Multiply Test
                [TestMethod]
                public void TestMethodTestMultiply200With100andEqual20K()
                {
                    double result = 0;

                    Calculator calc = new Calculator();
                    result = calc.Mult(100, 200);

                    Assert.AreEqual(100 * 200, result, "100*200 is not eqaul 20K");
                }
                [TestMethod]
                public void TestMethodTestMultiplyNegative200With100andEqualMinus20K()
                {
                    double result = 0;

                    Calculator calc = new Calculator();
                    result = calc.Mult(100, -200);

                    Assert.AreEqual(100 * (-200), result, "100*(-200) is not eqaul -20K");
                }
                [TestMethod]
                public void TestMethodTestMultiplyNegative200WithNegative100andEqual20K()
                {
                    double result = 0;

                    Calculator calc = new Calculator();
                    result = calc.Mult(100, -200);

                    Assert.AreEqual(100 * (-200), result, "100*(-200) is not eqaul -20K");
                }
                //Devide Tests
                [TestMethod]
                public void TestMethodTestDevide5With24andEqualHalf()
                {
                    double result = 0;
                    //(double)Math.Abs(n1 / n2)

                    Calculator calc = new Calculator();
                    result = calc.Devd(2, 4);

                    Assert.IsTrue(Math.Abs((2.0 / 4) - result) < 0.01, "24/5 is not eqaul 4,8");
                }
                /*[TestMethod]
                public void TestMethodTestDevideNegative200With100andEqualMinusHalf()
                {
                    double result = 0;

                    Calculator calc = new Calculator();
                    result = calc.Devd(100, -200);

                    Assert.AreEqual((double)100 / -200, result, "100/-200) is not eqaul -0,5");
                }
                [TestMethod]
                public void TestMethodTestDevideNegative200WithNegative100andEqualMinusHalf()
                {
                    double result = 0;

                    Calculator calc = new Calculator();
                    result = calc.Devd(-100, -200);

                    Assert.AreEqual((double)-100 / -200, result, "-100/-200) is not eqaul 0,5");
                }*/
            }
        }
    }
}