using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    public interface IManager
    {
        decimal FeettoInch(Conversion value);

        decimal InchToFeet(Conversion value);

        decimal MetertoCentimeter(Conversion value);

        decimal CentimetertoMeter(Conversion value);

        decimal KgtoGm(Conversion value);

        decimal GmtoKg(Conversion value);
    }
}
