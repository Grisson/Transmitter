using System;

namespace Common
{
    public class BaseDataPackage
    {
        protected bool CheckValueRangeIncludeEdge(byte currentValue, byte min, byte max)
        {
            if ((currentValue < min) || (currentValue > max))
            {
                throw new ArgumentOutOfRangeException($"current value is {currentValue}. The range is ");
            }

            return true;
        }
    }
}
