using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pizzapan.EntityLayer.Concrete;
using Pizzapan.PresentationLayer.Models;
using System.Threading.Tasks;

namespace Pizzapan.PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var result= await _signInManager.PasswordSignInAsync(model.Username, model.Password,true,true);
            if(result.Succeeded)
            {
                return RedirectToAction("Index","Category");

            }
            return View();
        }

        [HttpGet]
        public  IActionResult ConfirmEmail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmEmail(ConfirmMailViewModel model)
        {
            var result = await _userManager.FindByNameAsync(model.Username);
            if (result.ConfirmCode == model.ConfirmCode)
            {
                result.EmailConfirmed = true;
                await _userManager.UpdateAsync(result);
                return RedirectToAction("Index","Login");
            }           
                return View();                     
        }
    }
}
