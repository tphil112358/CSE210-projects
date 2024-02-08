using System;

public class Fraction
{
    private int localDividend;
    private int localDivisor;

    public Fraction()
    {
        localDividend = 1;
        localDivisor = 1;
    }

    public Fraction(int wholeNumber)
    {
        localDividend = wholeNumber;
        localDivisor = 1;
    }

    public Fraction(int dividend, int divisor)
    {
        localDividend = dividend;
        localDivisor = divisor;
    }

    public string GetFractionString()
    {
        string fractionString = $"{localDividend}/{localDivisor}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)localDividend / (double)localDivisor;
        return decimalValue;
    }
}