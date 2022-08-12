using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum
{
    /// <summary>
    /// Here We Are Checking Four Integer Number Using Compare To Method And Check The Maximum Number.
    /// </summary>
    public class MaximumFourGenerics<T> where T : IComparable
    {
        public T num1, num2, num3, num4;
        //  Find Maximum Number.
        public MaximumFourGenerics(T num1, T num2, T num3, T num4)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
            this.num4 = num4;
        }
        public T CheckFourGenerics(T num1, T num2, T num3, T num4)
        {

        
            //Use ComparteTO Comparision Between Four Integer Number.
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 && num1.CompareTo(num4) > 0)
            {
                return num1;
            }


            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 && num2.CompareTo(num4) > 0)
            {
                return num2;
            }


            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 && num3.CompareTo(num4) > 0)
            {
                return num3;
            }


            if (num4.CompareTo(num1) > 0 && num4.CompareTo(num2) > 0 && num4.CompareTo(num3) > 0)
            {
                return num4;
            }

            return num1;//Return While All Among Four Are Equal.
        }
    }
}

