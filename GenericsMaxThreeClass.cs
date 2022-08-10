using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    /// <summary>
    /// Here We Are Creating One Generic Class In That We Check Maximum Among Three Generic Type Variable.
    /// </summary>
    
   public class GenericsMaxThreeClass <T> where T : IComparable
    {
       // Declaring Class /Instance Level Generic Variables.
          public T firstValue, secondValue, thirdValue;
        
        //Generic Constructor (Parameterized)
        public GenericsMaxThreeClass(T firstValue, T secondValue, T thirdValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;
        }
              //Declaring Generic Method For Calculation.
            public T GenericsMaxAmong(T firstValue, T secondValue, T thirdValue)
            {
                if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                        firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                        firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
                {
                    return firstValue;
                }
                if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                       secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                       secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
                {
                    return secondValue;
                }
                if (thirdValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(secondValue) > 0 ||
                       thirdValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(secondValue) > 0 ||
                       thirdValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(secondValue) >= 0)
                {
                    return thirdValue;
                }
                return firstValue;//Return While All Among Three Are Equal.
        }
            
    }
}
