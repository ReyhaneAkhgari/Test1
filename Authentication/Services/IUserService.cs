namespace Authentication.Services
{
    public class IUserService
    {
        Models.User.GetById(int id);

        System.Collections.Generic.IEnumerable<Models.User> GetAll();

        ViewModels.Users.LoginRequestViewModel
            Login(ViewModels.Users.LoginRequestViewModel viewModel);
    }
}
