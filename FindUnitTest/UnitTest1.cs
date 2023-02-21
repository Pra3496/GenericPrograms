using GenericPrograms;

namespace FindUnitTest
{
    public class Tests
    {

        FindMaxNumber<int> genInteger = new FindMaxNumber<int>();
        FindMaxNumber<double> genDouble = new FindMaxNumber<double>();
        FindMaxNumber<string> genString = new FindMaxNumber<string>();



        ///////////////////        Test Maximum Integer        ///////////////////////

        [Test]
        public void GinvenMaxFirstNum_WhenAnalysed_shouldReturnFirstMax()
        {
            int result = genInteger.maxValue(37, 25, 18);
            Assert.AreEqual(37, result);
            Assert.Pass();

        }

        [Test]
        public void GinvenMaxSecondNum_WhenAnalysed_shouldReturnSecondMax()
        {
            int result = genInteger.maxValue(25, 57, 37);
            Assert.AreEqual(57, result);
            Assert.Pass();

        }







        ///////////////////         Test Maximum Double        ///////////////////////

        [Test]
        public void GinvenMaxFirstNum_WhenAnalysed_shouldReturnFirstMaxDouble()
        {
            double result = genDouble.maxValue(96.35,11.54,77.65);
            Assert.AreEqual(96.35, result);
            Assert.Pass();

        }

        [Test]
        public void GinvenMaxSecondNum_WhenAnalysed_shouldReturnSecondMaxDouble()
        {
            double result = genDouble.maxValue(45.35, 85.54, 77.65);
            Assert.AreEqual(85.54, result);
            Assert.Pass();

        }



        ///////////////////         Test Maximum String        ///////////////////////

        [Test]
        public void GinvenMaxFirstNum_WhenAnalysed_shouldReturnFirstMaxString()
        {
            string result = genString.maxValue("pranavy","pranav","pranav");
            Assert.AreEqual("pranavy", result);
            Assert.Pass();

        }

        [Test]
        public void GinvenMaxSecondNum_WhenAnalysed_shouldReturnSecondMaxString()
        {
            string result = genString.maxValue("ton", "tony", "ton");
            Assert.AreEqual("tony", result);
            Assert.Pass();

        }


    }
}