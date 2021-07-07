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
            int num1 = 5, num2 = 3,num3 = 4,expectedoutput =0,actualoutput = 0;
            actualoutput = findThree.FindMaxNumber(num1,num2,num3);
            expectedoutput = num1;
            Assert.AreEqual(actualoutput,expectedoutput);
        }
    }

    
}
