using DBased.Management;

namespace DBased.Schema;

public interface ISchema
{
    public IDBManagementSystem DBMS { get;}
    public IEnumerable<Table> Tables { get; }
}