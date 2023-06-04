using System.Net;

namespace UmbraClient.MVVM.Model;

internal interface IUserRepository
{
    bool AuthenticateUser(NetworkCredential networkCredential);
    void Add(UserModel userModel);
    void Edit(UserModel userModel);
    void Remove(int id);

    UserModel GetById(int id);
    UserModel GetByName(string username);
    IEnumerable<UserModel> GetAll();
}