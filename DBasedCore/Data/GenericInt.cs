namespace DBased.Data;

public class GenericInt: IDataType
{
    Classification IDataType.Classification { get { return Classification.NumericClass; } }
}