namespace DBased.Management;

public class MSSQL: IDBManagementSystem
{
    DBSystem IDBManagementSystem.System { get { return DBSystem.MSSql; } }
    string IDBManagementSystem.Version { get { return "2019"; } set { } }

    public MSSQL()
    {
        
    }
}