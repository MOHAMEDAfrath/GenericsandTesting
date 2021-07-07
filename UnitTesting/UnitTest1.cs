using GenericsAndTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        FindThreeNumbers<int> findThree;
        FindThreeNumbers<double> findThree1;
        FindThreeNumbers<string> findThree2;

        [TestInitialize]
        public void SetUp()
        {
            findThree = new FindThreeNumbers<int>(5,2,3);
            findThree1 = new FindThreeNumbers<double>(5.4, 2.2, 3.4);
            findThree2 = new FindThreeNumbers<string>("Cycle", "Car", "Bike");
        }
        
        [TestMethod]
        public void TestMethod1()
        {
            var actualoutput = findThree.Max();
            var expectedoutput = 5;
            Assert.AreEqual(actualoutput, expectedoutput);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var actualoutput = findThree1.Max();
            var expectedoutput = 5.4;
            Assert.AreEqual(actualoutput, expectedoutput);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var actualoutput = findThree2.Max();
            var expectedoutput = "Cycle";
            Assert.AreEqual(actualoutput, expectedoutput);

        }
    }

    
}
