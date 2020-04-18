using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepoImpl : IRepository
    {
        public  decimal FeettoInch(Conversion value)
        {
            return value.Feet * 12; 
        }

        public decimal InchToFeet(Conversion value)
        {
            return value.Inch / 12;
        }

        public decimal GmtoKg(Conversion value)
        {
            return value.Gram / 1000;
        }

        public decimal MetertoCentimeter(Conversion value)
        {
            return value.Meter * 100;
        }

        public decimal CentimetertoMeter(Conversion value)
        {
            return value.Centimeter / 100;
        }

        public decimal KgtoGm(Conversion value)
        {
            return value.KiloGram * 1000;
        }
    }
}
