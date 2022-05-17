using DBased.Data;

namespace DBased.Schema;

public class Column
{
    public DataType DataType { get; }
    public string Name { get; }

    public Column()
    {
        DataType = MSDataType.Char;
        Name = "Default";
    }
    public Column(DataType type, string name)
    {
        DataType = type;
        Name = name;
    }
}