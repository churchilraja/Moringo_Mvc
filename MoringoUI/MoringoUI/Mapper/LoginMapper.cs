using MoringoUI.ViewModels;

namespace MoringoUI.Mapper
{
    public class LoginMapper : ILoginMapper
    {
        public LoginViewModel Map(string userName, string password)
        {
            return new LoginViewModel { UserName = userName, Password = password };
        }
    }

    public interface ILoginMapper
    {
        LoginViewModel Map(string userName, string password);
    }
}