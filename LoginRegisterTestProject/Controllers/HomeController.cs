using LoginRegisterTestProject.Models;
using LoginRegisterTestProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginRegisterTestProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View("Login");
        }
        public IActionResult Register()
        {
            return View("Register");
        }
        public async Task<IActionResult> LoginCheck(UserLoginDTO userLoginDTO)
        {
            bool check = await _userService.Check(userLoginDTO);
            if (check)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Login");
            }
        }
        public async Task<IActionResult> AddUser(UserToAddDTO user)
        {
            await _userService.Add(user);
            return RedirectToAction("Login", "Home");
        }
    }
}