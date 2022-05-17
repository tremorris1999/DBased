using System.Reflection;

namespace DBased.Data;

public abstract class DataType: IComparable
{
    public abstract string Name { get; }
    public abstract int Id { get; }

    public static IEnumerable<T> GetAll<T>() where T : DataType
    {
        return typeof(T).GetFields(BindingFlags.Public |
                                    BindingFlags.Static |
                                    BindingFlags.DeclaredOnly)
                            .Select(item => item.GetValue(null))
                            .Cast<T>();
    }
    
    public int CompareTo(object? other)
    {
        if(other is null)
            return -1;

        return Id.CompareTo(((DataType)other).Id);
    }
}