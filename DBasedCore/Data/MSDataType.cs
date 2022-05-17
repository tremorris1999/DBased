namespace DBased.Data;

public sealed class MSDataType: DataType
{
    public sealed override string Name { get; }
    public sealed override int Id { get; }
    public readonly static MSDataType Char = new("Char", 1);
    public readonly static MSDataType VarChar = new("VarChar", 2);
    public readonly static MSDataType Text = new("Text", 3);
    public readonly static MSDataType NChar = new("NChar", 4);
    public readonly static MSDataType NVarChar = new("NVarChar", 5);
    public readonly static MSDataType NText = new("NText", 5); 
    public readonly static MSDataType Binary = new("Binary", 6);    
    public readonly static MSDataType VarBinary = new("VarBinary", 7);    
    public readonly static MSDataType Image = new("Image", 8);    
    public readonly static MSDataType Bit = new("Bit", 9);   
    public readonly static MSDataType TinyInt = new("TinyInt", 10);   
    public readonly static MSDataType SmallInt = new("SmallInt", 11);   
    public readonly static MSDataType Int = new("Int", 12);   
    public readonly static MSDataType BigInt = new("BigInt", 13);
    public readonly static MSDataType Decimal = new("Decimal", 14);
    public readonly static MSDataType Numeric = new("Numeric", 15);
    public readonly static MSDataType SmallMoney = new("SmallMoney", 16);
    public readonly static MSDataType Money = new("Money", 17);
    public readonly static MSDataType Float = new("Float", 18);
    public readonly static MSDataType Real = new("Real", 19);    
    //TODO: add other data types

    private MSDataType(string name, int id)
    {
        Name = name;
        Id = id;
    }
}