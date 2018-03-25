using MoringoUI.Adapter;
using MoringoUI.Mapper;
using System.Web.Mvc;

namespace MoringoUI.Controllers
{
    public class HomeController : Controller
    {
        private ILoginAdapter _loginAdapter { get; set; }
        private ILoginMapper _loginMapper { get; set; }

        public HomeController()
        {
            _loginAdapter = new LoginAdapter();
            _loginMapper = new LoginMapper();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string userName, string password)
        {
            var loginModel = _loginAdapter.Execute(_loginMapper.Map(userName, password));

            return View(loginModel);
        }
    }
}