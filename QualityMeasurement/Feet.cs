using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace QualityMeasurement
{
    public class Feet 
    {
        public int feet;
        private object p;

        public Feet()
        {
        }

        public Feet(int feet)
        {
            this.feet = feet;
        }

        public Feet(object p)
        {
            this.p = p;
        }

        public bool ConvertFeetValue(Feet feet)
        {
            if (this.feet.Equals(feet.feet))
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else
                return true;
        }
    }
}
