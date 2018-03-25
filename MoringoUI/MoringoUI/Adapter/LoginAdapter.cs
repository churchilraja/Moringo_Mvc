using System;
using System.Collections.Generic;
using System.Linq;
using MoringoUI.ViewModels;
using MoringoUI.Common;


namespace MoringoUI.Adapter
{
    public class LoginAdapter : ILoginAdapter
    {
        public ErrorDetails Execute(LoginViewModel loginViewModel)
        {
            //this will call the API Layer and get the details from API.
            throw new NotImplementedException();
        }
    }

    public interface ILoginAdapter
    {
        ErrorDetails Execute(LoginViewModel loginViewModel);
    }
}