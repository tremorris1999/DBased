using DBased.Schema.Key;

namespace DBased.Schema;

public class Table
{
    public string Name { get; }
    public IEnumerable<Column> Columns { get; }
    public IKey PrimaryKey { get; }
    public IEnumerable<IKey> CandidateKeys { get; }
    public IEnumerable<IKey> ForeignKeys { get; }

    public Table(string name)
    {
        Name = name;
        Columns = new Column[1]{ new Column("id")};
        PrimaryKey = new PrimaryKey(Columns.ToArray()[0]);
        CandidateKeys = new IKey[0];
        ForeignKeys = new IKey[0];
    }
}