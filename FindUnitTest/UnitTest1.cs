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

        



        ///////////////////         Test Maximum Double        ///////////////////////

        [Test]
        public void GinvenMaxFirstNum_WhenAnalysed_shouldReturnFirstMaxDouble()
        {
            double result = genDouble.maxValue(96.35,11.54,77.65);
            Assert.AreEqual(96.35, result);
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

        

    }
}