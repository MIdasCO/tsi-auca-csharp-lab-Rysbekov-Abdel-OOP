using System;

public interface IRootFindingStrategy
{
    Complex[] FindRoots(double[] coefficients);
}