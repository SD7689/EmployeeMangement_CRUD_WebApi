using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
    public class Inch
    {
        public int inch;

        public Inch()
        {

        }

        public Inch(int inch)
        {
            this.inch = inch;
        }

        public int EqualsValue()
        {
            return this.inch;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null )|| Object.ReferenceEquals(this, obj))
                return true;
            
             return false;
        }
    }
}
