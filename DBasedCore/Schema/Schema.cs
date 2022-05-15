using DBased.Management;

namespace DBased.Schema;

public class Schema
{
    public DBManagementSystem DBMS { get;}

    public Schema(DBManagementSystem dbms)
    {
        DBMS = dbms;
    }
}