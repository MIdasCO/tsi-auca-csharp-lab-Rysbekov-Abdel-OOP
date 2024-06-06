using System;

public class LinearEquationSolver : IRootFindingStrategy
{
    public Complex[] FindRoots(double[] coefficients)
    {
        if (coefficients.Length != 2)
            throw new InvalidOperationException("Invalid number of coefficients for linear equation");

        double a = coefficients[0];
        double b = coefficients[1];

        if (a == 0)
            throw new InvalidOperationException(b == 0 ? "Infinite number of solutions" : "No complex roots");

        return new Complex[] { new Complex(-b / a, 0) };
    }
}
