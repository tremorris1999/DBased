namespace DBased.Schema.Key;

public class PrimaryKey: IKey
{
    KeyClassification IKey.Classification { get { return KeyClassification.PrimaryKey; } }

    public PrimaryKey(Column column)
    {
        
    }

}