using GenericsAndTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        FindThreeNumbers findThree;
        [TestInitialize]
        public void SetUp()
        {
            findThree = new FindThreeNumbers(); 
        }

        [TestMethod]
        public void TestMethod()
        {
            double num1 = 5.2, num2 = 3.5, num3 = 4.7, expectedoutput = 0, actualoutput = 0;
            actualoutput = findThree.FindMaxNumber(num1, num2, num3);
            expectedoutput = num1;
            Assert.AreEqual(actualoutput, expectedoutput);
        }
        [TestMethod]
        public void TestMethod1()
        {
            //Test case 2 with large double number at number2
            double num1 = 3.5, num2 = 5.2, num3 = 4.7, expectedoutput = 0, actualoutput = 0;
            actualoutput = findThree.FindMaxNumber(num1, num2, num3);
            expectedoutput = num2;
            Assert.AreEqual(actualoutput, expectedoutput);
        }
            [TestMethod]
            public void TestMethod3()
            {
                double num1 = 3.5, num2 = 4.7, num3 = 5.2, expectedoutput = 0, actualoutput = 0;
                actualoutput = findThree.FindMaxNumber(num1, num2, num3);
                expectedoutput = num3;
                Assert.AreEqual(actualoutput, expectedoutput);
            }





        }
    }

    

