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
        public void TestMethod1()
        {
            //Test case 1 with large integer number at number1
            /*
            int num1 = 5, num2 = 3,num3 = 4,expectedoutput =0,actualoutput = 0;
            actualoutput = findThree.FindMaxNumber(num1,num2,num3);
            expectedoutput = num1;
            Assert.AreEqual(actualoutput,expectedoutput);
             //Test case 1 with large integer number at number2
            int num1 = 3, num2 = 5, num3 = 4, expectedoutput = 0, actualoutput = 0;
            actualoutput = findThree.FindMaxNumber(num1, num2, num3);
            expectedoutput = num2;
            Assert.AreEqual(actualoutput, expectedoutput);
            //Test case 1 with large integer number at number3
            int num1 = 3, num2 = 4, num3 = 5, expectedoutput = 0, actualoutput = 0;
            actualoutput = findThree.FindMaxNumber(num1, num2, num3);
            expectedoutput = num3;
            Assert.AreEqual(actualoutput, expectedoutput);*/
            //Test case 2 with large double number at number1
            /*
            double num1 = 5.2, num2 = 3.5, num3 = 4.7, expectedoutput = 0, actualoutput = 0;
            actualoutput = findThree.FindMaxNumber(num1, num2, num3);
            expectedoutput = num1;
            Assert.AreEqual(actualoutput, expectedoutput);
           //Test case 2 with large double number at number2
           double num1 = 3.5, num2 = 5.2, num3 = 4.7, expectedoutput = 0, actualoutput = 0;
           actualoutput = findThree.FindMaxNumber(num1, num2, num3);
           expectedoutput = num2;
           Assert.AreEqual(actualoutput, expectedoutput);
           //Test case 2 with large double number at number3
           double num1 = 3.5, num2 = 4.7, num3 = 5.2, expectedoutput = 0, actualoutput = 0;
           actualoutput = findThree.FindMaxNumber(num1, num2, num3);
           expectedoutput = num3;
           Assert.AreEqual(actualoutput, expectedoutput);*/
            //Test case 3 with large string at number1
            /* string num1 = "Cycle", num2 = "Bike", num3 = "Car", expectedoutput = "", actualoutput = "";
             actualoutput = findThree.FindMaxNumber(num1, num2, num3);
             expectedoutput = num1;
             Assert.AreEqual(actualoutput, expectedoutput);*/
            /*
             //Test case 3 with large string at number1
             string num1 = "Bike", num2 = "Cylce", num3 = "Car", expectedoutput = "", actualoutput = "";
             actualoutput = findThree.FindMaxNumber(num1, num2, num3);
             expectedoutput = num2;
             Assert.AreEqual(actualoutput, expectedoutput);*/
            string num1 = "Bike", num2 = "Car", num3 = "Cycle", expectedoutput = "", actualoutput = "";
            actualoutput = findThree.FindMaxNumber(num1, num2, num3);
            expectedoutput = num3;
            Assert.AreEqual(actualoutput, expectedoutput);





        }
    }

    
}
