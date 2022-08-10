using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    /// <summary>
    /// Here We Are Checking Maximum Integer Number By Using CompareTO Method. 
    /// </summary>
    class IntMaximum
    {
        // Maximum To Find Max Integer Number.
        public int  MaximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            // Use CompareTO Comparision Between Three Integer Number.
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
