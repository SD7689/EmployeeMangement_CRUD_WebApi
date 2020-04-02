using System;
using System.Collections.Generic;
using System.Text;

namespace QualityMeasurement
{
    public class UnitCheck
    {
        public string type;
        public int Length;

        public UnitCheck()
        {

        }

        public UnitCheck(string type , int Length)
        {
            this.type = type;
            this.Length = Length;
        }

        public UnitCheck(string type)
        {
            this.type = type;
        }

        public int EqualsValue()
        {
            return this.Length;
        }

        public int ConvertFeetToInch()
        {
            return this.Length * 12;
        }
        public double ConvertInchToFeet()
        {
            return this.Length / 12;
        }

        public int ConverFeetintoYard()
        {
            return this.Length / 3;
        }


        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }

    }
}
