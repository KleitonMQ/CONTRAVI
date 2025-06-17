
namespace CONTRAVI.Application.ViewModels
{
    public class GetDriverByLoginViewModel
    {
        public GetDriverByLoginViewModel(string userName, string login, string token)
        {
            UserName = userName;
            Login = login;
            Token = token;
        }
        public string UserName { get; set; }
        public string Login {  get; set; }
        public string Token { get; set; }

    }
}
