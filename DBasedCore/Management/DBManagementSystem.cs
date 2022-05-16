
namespace DBased.Management;

public interface IDBManagementSystem
{
    public DBSystem System { get; }
    public string Version { get; set; }
    
}