using System;
using System.Collections.Generic;
using System.Linq;

public class Equation : IEquation
{
    private readonly double[] _coefficients;
    private readonly IRootFindingStrategy _strategy;

    public int Dimension => _coefficients.Length;
    public double[] Coefficients => (double[])_coefficients.Clone();

    public Equation(double[] coefficients)
    {
        _coefficients = EquationUtils.RemoveLeadingZeroes(coefficients);
        _strategy = EquationUtils.ChooseStrategy(_coefficients);
    }

    public Complex[] FindRoots()
    {
        if (_coefficients.Length < 1)
            throw new InvalidOperationException("Invalid equation coefficients");

        return _strategy.FindRoots(_coefficients);
    }
}