using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    /// <summary>
    /// Here We Are Checking Maximum Flaot Number by Using CompareTO Method.
    /// </summary>
    class FloatMaximum
    {
        //Method to Find Maximum Float Number.
        public float MaximumFloatNumber(float firstValue, float secondValue, float thirdValue)
        {
            //Use CompareTo For Comparision Between Three Float Number
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                    firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                    firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue; //Return The Greater Float Number.
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
