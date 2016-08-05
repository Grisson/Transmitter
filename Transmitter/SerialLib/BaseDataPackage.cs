using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialLib
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
