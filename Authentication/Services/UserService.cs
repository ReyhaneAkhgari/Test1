using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.View;
using System.Linq;
namespace Authentication.Services;
{
    public class userServise : Object, IUserService
{
    public UserService(Microsoft.Extensions.Options.IOptions<Infrastructure.ApplicationSettings.Main> options) : base()
    {
        MainSettings = options.Value;
    }
    protected Infrastructure.ApplicationSettings.Main.MainSettings{get;}
    private System.Collections.Generic.List<Models.User> _users;

    protected System.Collections.Generic.List<Models.User> Users
{
    get
    {
        if (_users == null)
        {
            _users=new.System.Collections.Generic.List<Models.User>();

            for(int index = 1; index <= 9; index++)
            {
                var user=new Models.User
                {
                    Id=index,
                    Password="1234567890",
                    Username=$"Username{index}",
                    LastName=$"Last Name{index}",
                    FirstName=$"First Name{index}",
                    EmailAddress=$"Email{index} @Gmail.com"
                }
                _users.Add(user)
            }
        }
        return _users;
    }
}
public Models.User.GetById(int id){
    Models.User.foundedUser=Users.Where(Current=>Current.Id==id).FirstOrDefault();
    
    return.foundedUser;
    }


public viewModels.Users.LoginResponseViewModel
}
    Login(viewModels.users.LoginResponseviewModel viewModel){
    if (viewModel == null)
    {
        return null
    }
    if(string.IsNullOrWhiteSpace(ViewModel.Username))
    {
        return null;
    }
    if (string.IsNullOrWhiteSpace(viewModel.Password))
    {
        return null;
    }
}
Models.User.foundedUser=Users.where(current=>current.Username.ToLower()==viewModel.Username.ToLower()).FirstOrDefault();

if (foundedUser == null)
{
    return null;
}
//
if (string.Compare(foundedUser.Password, viewModel.Password, ignoreCase: false) != 0)
{
    return null;
}
}

//using Authentication.Entities;
/// <summary>
/// using Authentication.Entities;
/// </summary>
/*
public interface IUserService
{
    Task<User> Authenticate(string username, string password);
    Task<IEnumerable<User>> GetAll();
}
*/
/*
public class UserService :Object, IUserService
{
    // users hardcoded for simplicity, store in a db with hashed passwords in production applications
    private List<User> _users = new List<User>
    {
        new User { Id = 1, FirstName = "Test", LastName = "User", Username = "test", Password = "test" }
    };

    public async Task<User> Authenticate(string username, string password)
    {
        // wrapped in "await Task.Run" to mimic fetching user from a db
        var user = await Task.Run(() => _users.SingleOrDefault(x => x.Username == username && x.Password == password));

        // on auth fail: null is returned because user is not found
        // on auth success: user object is returned
        return user;
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        // wrapped in "await Task.Run" to mimic fetching users from a db
        return await Task.Run(() => _users);
    }
*/
