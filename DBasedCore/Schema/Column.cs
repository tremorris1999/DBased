using DBased.Data;

namespace DBased.Schema;

public class Column
{
    public IDataType DataType { get; }
    public string Name { get; }

    public Column(string name)
    {
        DataType = new GenericInt();
        Name = name;
    }
    public Column(IDataType type, string name)
    {
        DataType = type;
        Name = name;
    }

}