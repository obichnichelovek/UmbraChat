using System.Data.SqlClient;

namespace UmbraClient.Repos;

internal abstract class RepositoryBase
{
    private readonly string connectionString;

    public RepositoryBase()
    {
        connectionString = "Server=(local)\\SQLExpress;Initial Catalog=UmbraDB;Integrated Security=True";
    }

    private protected SqlConnection GetConnection() => new(connectionString);
}