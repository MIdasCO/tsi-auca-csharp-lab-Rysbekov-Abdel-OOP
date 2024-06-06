using System;
using System.Collections.Generic;
using System.Linq;

public static class EquationManager
{
    public static IEquation CreateEquation(double[] coefficients)
    {
        double[] cleanedCoefficients = EquationUtils.RemoveLeadingZeroes(coefficients);
        IRootFindingStrategy strategy = EquationUtils.ChooseStrategy(cleanedCoefficients);
        return new Equation(cleanedCoefficients);
    }
}