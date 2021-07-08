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
        FindThreeNumbers<int> find;

        [TestInitialize]
        public void SetUp()
        {
            findThree = new FindThreeNumbers<int>(5,2,3);
            findThree1 = new FindThreeNumbers<double>(5.4, 2.2, 3.4);
            findThree2 = new FindThreeNumbers<string>("Cycle", "Car", "Bike");
            int[] arr = { 52, 60, 225, 21, 55 };
            find = new FindThreeNumbers<int>(arr);
        }
        
        [TestMethod]
        public void IntMethod()
        {
            var actualoutput = findThree.Max();
            var expectedoutput = 5;
            Assert.AreEqual(actualoutput, expectedoutput);
        }
        [TestMethod]
        public void DFDoubleMethod()
        {
            var actualoutput = findThree1.Max();
            var expectedoutput = 5.4;
            Assert.AreEqual(actualoutput, expectedoutput);
        }
        [TestMethod]
        public void StringMethod()
        {
            var actualoutput = findThree2.Max();
            var expectedoutput = "Cycle";
            Assert.AreEqual(actualoutput, expectedoutput);

        }
        [TestMethod]
        public void ArrayMethod()
        {
            
            var actualoutput = find.MaxArray();
            var expectedoutput = 225;
            Assert.AreEqual(actualoutput, expectedoutput);

        }

    }

    
}
