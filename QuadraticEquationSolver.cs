using System;

public class QuadraticEquationSolver : IRootFindingStrategy
{
    public Complex[] FindRoots(double[] coefficients)
    {
        if (coefficients.Length != 3)
            throw new InvalidOperationException("Invalid number of coefficients for quadratic equation");

        double a = coefficients[0];
        double b = coefficients[1];
        double c = coefficients[2];

        double discriminant = b * b - 4 * a * c;
        if (discriminant >= 0)
        {
            double sqrtDisc = Math.Sqrt(discriminant);
            return new Complex[]
            {
                new Complex((-b + sqrtDisc) / (2 * a), 0),
                new Complex((-b - sqrtDisc) / (2 * a), 0)
            };
        }
        else
        {
            double sqrtDisc = Math.Sqrt(-discriminant);
            return new Complex[]
            {
                new Complex(-b / (2 * a), sqrtDisc / (2 * a)),
                new Complex(-b / (2 * a), -sqrtDisc / (2 * a))
            };
        }
    }
}
