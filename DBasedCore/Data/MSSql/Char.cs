
using System;
namespace DBased.Data.MSSql;

public class Char: IDataType
{
    Classification IDataType.classification { get { return Classification.StringClass; } }
    public int Width { get; }

    public Char(int width)
    {
        if(width > 8000 || width < 1)
            throw new ArgumentException("Char width must be between 1 and 8000 inclusive.");

        Width = width;
    }
}