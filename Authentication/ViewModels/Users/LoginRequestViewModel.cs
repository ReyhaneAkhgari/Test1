namespace Authentication.ViewModels.Users
{
    public class LoginRequestViewModel:Object
    {
        public LoginRequestViewModel():base ()
        { }
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings=false)]
        public string UserName { get; set; }
        [System.ComponentModel.DataAnnotations.Required
            (AllowEmptyStrings =false)] 
        public string Password { get; set;}
    }

}
