using System;
using System.Collections.Generic;
using System.Text;

namespace Maximum
{ 
   /// <summary>
   /// Here We Are Checking Four Integer Number Using Compare To Method And Check The Maximum Number.
   /// </summary>
   public  class MaximumFour
    {
        
            // Maximum To Find Max Integer Number.
            public  int MaximumInteger(int num1, int num2, int num3, int num4)
            {

              //Use ComparteTO Comparision Between Four Integer Number.
               if(num1.CompareTo(num2)>0 && num1.CompareTo(num3) > 0 && num1.CompareTo (num4)>0)
            {
                return num1;
            }


            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 && num2.CompareTo(num4) >0)
            {
                return num2;
            }


            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 && num3.CompareTo(num4)>0)
            {
                return num3;
            }


            if (num4.CompareTo(num1) > 0 && num4.CompareTo(num2) > 0 && num4.CompareTo(num3)>0)
            {
                return num4;
            }

            return num1;//Return While All Among Four Are Equal.
            }
        }
}
