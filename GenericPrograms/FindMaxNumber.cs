using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrograms
{
    public class FindMaxNumber<T> where T : IComparable
    {

        public T tNo1, tNo2, tNo3;

        public FindMaxNumber(T tNo1, T tNo2, T tNo3) 
        {
            this.tNo1 = tNo1;
            this.tNo2 = tNo2;
            this.tNo3 = tNo3;
        }
        public T maxValue(T tNo1, T tNo2, T tNo3)
        {

            if ( (tNo1.CompareTo(tNo2) > 0 && tNo1.CompareTo(tNo3) > 0) || (tNo1.CompareTo(tNo2) >= 0 && tNo1.CompareTo(tNo3) > 0) || ( tNo1.CompareTo(tNo2) > 0 && tNo1.CompareTo(tNo3) > 0))
            {
                return tNo1;
            }
            if ( (tNo2.CompareTo(tNo1) > 0 && tNo2.CompareTo(tNo3) > 0 ) || ( tNo2.CompareTo(tNo1) >= 0 && tNo2.CompareTo(tNo3) > 0 ) || ( tNo2.CompareTo(tNo1) > 0 && tNo2.CompareTo(tNo3) >= 0))
            {
                return tNo2;
            }
            if ((tNo3.CompareTo(tNo1) > 0 && tNo3.CompareTo(tNo2) > 0) || (tNo3.CompareTo(tNo1) >= 0 && tNo3.CompareTo(tNo2) > 0) || (tNo3.CompareTo(tNo1) > 0 && tNo3.CompareTo(tNo2) >= 0))
            {
                return tNo3;
            }
           
            throw new Exception("Number one,Two and three are same");
            
        }

        public T maxMethod()
        {
            T max = maxValue(this.tNo1, this.tNo2, this.tNo3);
            return max;
        }
    }
}
