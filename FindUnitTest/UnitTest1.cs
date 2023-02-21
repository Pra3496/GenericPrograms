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


        [Test]
        public void GinvenMaxThirdNum_WhenAnalysed_shouldReturnThirdMax()
        {
            int result = genInteger.maxValue(21, 42, 89);
            Assert.AreEqual(89, result);
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


        [Test]
        public void GinvenMaxTThirdNum_WhenAnalysed_shouldReturnThirdMaxDouble()
        {
            double result = genDouble.maxValue(45.6, 112.54, 777.65);
            Assert.AreEqual(777.65, result);
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

        [Test]
        public void GinvenMaxTThirdNum_WhenAnalysed_shouldReturnThirdMaxString()
        {
            string result = genString.maxValue("rain", "rain", "rainy");
            Assert.AreEqual("rainy", result);
            Assert.Pass();

        }


        ///////////////////         Test Maximum Integer Array        ///////////////////////
       

        [Test]
        public void GinvenMaxNumFromArray_WhenAnalysed_shouldReturnMaxInteger()
        {
            int[] arr = { 14, 56, 899, 45, 85 };

            GenericMaximum<int> genArr = new GenericMaximum<int>(arr);
            int result = genArr.MaxMethod();

            Assert.AreEqual(899,result);

            Assert.Pass();

        }


        ///////////////////         Test Maximum Double Array        ///////////////////////

        [Test]
        public void GinvenMaxNumFromArray_WhenAnalysed_shouldReturnMaxDouble()
        {
            double[] arr = { 1.4, 5.6, 8.99, 9.5, 8.5 };

            GenericMaximum<double> genArr = new GenericMaximum<double>(arr);
            double result = genArr.MaxMethod();
            Assert.AreEqual(9.5, result);

            Assert.Pass();

        }

        ///////////////////         Test Maximum String Array        ///////////////////////

        [Test]
        public void GinvenMaxNumFromArray_WhenAnalysed_shouldReturnMaxString()
        {
            string[] arr = { "ton","toniy","tony","to","antony" };

            GenericMaximum<string> genArr = new GenericMaximum<string>(arr);
            string result = genArr.MaxMethod();

            Assert.AreEqual("tony", result);

            //Assert.Pass();

        }

    }
}