using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrograms
{
    internal class FindMaxNumber
    {

        public int maxInteger(int numOne, int numTwo, int numThree)
        {
            if (numOne.CompareTo(numTwo) > 0 && numOne.CompareTo(numThree) > 0)
            {
                return numOne;
            }
            if (numTwo.CompareTo(numOne) > 0 && numTwo.CompareTo(numThree) > 0)
            {
                return numTwo;
            }
            if (numThree.CompareTo(numOne) > 0 && numThree.CompareTo(numTwo) > 0)
            {
                return numThree;
            }
            throw new Exception("numOne,numTwo,numThree are same");
        }

        public float maxFloat(double valueOne, double valueTwo, double valueThree)
        {

            if (valueOne.CompareTo(valueTwo) > 0 && valueOne.CompareTo(valueThree) > 0)
            {
                return (float)valueOne;
            }
            if (valueTwo.CompareTo(valueOne) > 0 && valueTwo.CompareTo(valueThree) > 0)
            {
                return (float)valueTwo;
            }
            if (valueThree.CompareTo(valueOne) > 0 && valueThree.CompareTo(valueTwo) > 0)
            {
                return (float)valueThree;
            }
            throw new Exception("valueOne,valueTwo,valueThree are same");
        }

        public string maxString(string nameOne, string nameTwo, string nameThree)
        {

            if ( (nameOne.CompareTo(nameTwo) > 0 && nameOne.CompareTo(nameThree) > 0) || (nameOne.CompareTo(nameTwo) >= 0 && nameOne.CompareTo(nameThree) > 0) || ( nameOne.CompareTo(nameTwo) > 0 && nameOne.CompareTo(nameThree) > 0))
            {
                return nameOne;
            }
            if ( (nameTwo.CompareTo(nameOne) > 0 && nameTwo.CompareTo(nameThree) > 0 ) || ( nameTwo.CompareTo(nameOne) >= 0 && nameTwo.CompareTo(nameThree) > 0 ) || ( nameTwo.CompareTo(nameOne) > 0 && nameTwo.CompareTo(nameThree) >= 0))
            {
                return nameTwo;
            }
            if ((nameThree.CompareTo(nameOne) > 0 && nameThree.CompareTo(nameTwo) > 0) || (nameThree.CompareTo(nameOne) >= 0 && nameThree.CompareTo(nameTwo) > 0) || (nameThree.CompareTo(nameOne) > 0 && nameThree.CompareTo(nameTwo) >= 0))
            {
                return nameThree;
            }
            throw new Exception("nameOne,nameTwo,nameThree are same");
        }
    }
}
