using System.Data;
using System.Data.SqlClient;
using System.Net;
using UmbraClient.MVVM.Model;

namespace UmbraClient.Repos;

internal sealed class UserRepository : RepositoryBase, IUserRepository
{
    public void Add(UserModel userModel)
    {
        throw new NotImplementedException();
    }

    public bool AuthenticateUser(NetworkCredential networkCredential)
    {
        using var connection = GetConnection();
        using var command = new SqlCommand();

        connection.Open();

        command.Connection = connection;
        command.CommandText = "select * from [User] where username = @username and [password] = @password;";
        command.Parameters.Add("@username", SqlDbType.NVarChar).Value = networkCredential.UserName;
        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = networkCredential.Password;

        return command.ExecuteScalar() != null;
    }

    public void Edit(UserModel userModel)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<UserModel> GetAll()
    {
        throw new NotImplementedException();
    }

    public UserModel GetById(int id)
    {
        throw new NotImplementedException();
    }

    public UserModel GetByName(string username)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }
}