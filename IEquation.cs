using System;
using System.Collections.Generic;

public interface IEquation
{
    int Dimension { get; }
    double[] Coefficients { get; }
    Complex[] FindRoots();
}