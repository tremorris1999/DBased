
namespace DBased.Management;

public class DBManagementSystem
{
    public DBSystem System {get; }
    public string Version { get; set; }

    public DBManagementSystem(DBSystem system, string version)
    {
        System = system;
        Version = version;
    }
    
}