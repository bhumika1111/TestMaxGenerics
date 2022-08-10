using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    // Here We Are Creating One Generic Method In That We Check Maximum Among Three Generic Type Variable.
    class GenericsMaxThreeMethod
    {
        
            public T GenericsMaxAmongThre<T>(T firstValue, T secondValue, T thirdValue) where T : IComparable
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

