using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    /// <summary>
    /// Here We Are Checking Maximum String Value By Using CompareTO method.
    /// </summary>
    class StringMaximum
    {
        //Method To Find Maximum String Value.
        public string MaximumStringNumber(string firstValue, string secondValue, string thirdValue)
        {
            //Use CompareTO Comparision Between Three String Values.
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                    firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                    firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;//Return The Greater String Values.
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
