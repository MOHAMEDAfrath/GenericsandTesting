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

            //Test case 3 with large string at number1
            string num1 = "Cycle", num2 = "Bike", num3 = "Car", expectedoutput = "", actualoutput = "";
            actualoutput = findThree.FindMaxNumber(num1, num2, num3);
            expectedoutput = num1;
            Assert.AreEqual(actualoutput, expectedoutput);
        }
        [TestMethod]
        public void TestMethod1() {

            //Test case 3 with large string at number1
            string num1 = "Bike", num2 = "Cylce", num3 = "Car", expectedoutput = "", actualoutput = "";
            actualoutput = findThree.FindMaxNumber(num1, num2, num3);
            expectedoutput = num2;
            Assert.AreEqual(actualoutput, expectedoutput);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string num1 = "Bike", num2 = "Car", num3 = "Cycle", expectedoutput = "", actualoutput = "";
            actualoutput = findThree.FindMaxNumber(num1, num2, num3);
            expectedoutput = num3;
            Assert.AreEqual(actualoutput, expectedoutput);
        }

        }
    }

    

