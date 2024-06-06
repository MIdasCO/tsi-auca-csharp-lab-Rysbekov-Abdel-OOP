using System;
using System.Linq;

public static class EquationUtils
{
    public static double[] RemoveLeadingZeroes(double[] coefficients)
    {
        int firstNonZeroIndex = Array.FindIndex(coefficients, coeff => coeff != 0);
        return firstNonZeroIndex == -1 ? new double[] { 0 } : coefficients.Skip(firstNonZeroIndex).ToArray();
    }

    public static IRootFindingStrategy ChooseStrategy(double[] coefficients)
    {
        if (coefficients.Length == 2)
            return new LinearEquationSolver();
        if (coefficients.Length == 3)
            return new QuadraticEquationSolver();
        if (coefficients.Length == 4)
            return new CubicEquationSolver();

        throw new InvalidOperationException("Unsupported equation type");
    }
}