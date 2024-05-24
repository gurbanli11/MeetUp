////using LoginRegister.Models;
//using Meetup.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Build.Framework;
//using Microsoft.EntityFrameworkCore;

//namespace LoginRegister.Controllers
//{
//    public class AccountController : Controller
//    {
//        private readonly SignInManager<AppUser> _signInManager;
//        private readonly UserManager<AppUser> _userManager;

//        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
//        {
//            _signInManager = signInManager;
//            _userManager = userManager;
//        }
//        [Authorize]
//        public async Task<IActionResult> Index()
//        {
//            return View(await _userManager.Users.ToListAsync());
//        }
//        public IActionResult Login()
//        {
//            return View();
//        }
//        [HttpPost]
//        public async Task<IActionResult> Login(AppUser loginUser)
//        {
//            if (!ModelState.IsValid)
//                return View();

//            AppUser user = await _userManager.FindByNameAsync(loginUser.UserName);
//            if (user == null)
//                return NotFound();

//            var result = await _signInManager.PasswordSignInAsync(user, loginUser.PasswordHash, true, true);
//            if (result.Succeeded)
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            else
//            {
//                return BadRequest();
//            }
//        }
//        public IActionResult Register()
//        {
//            return View();
//        }
//        [HttpPost]
//        public async Task<IActionResult> Register(AppUser registerUser)
//        {
//            if (!ModelState.IsValid)
//                return View(registerUser);
//            var result = await _userManager.CreateAsync(registerUser, registerUser.PasswordHash);
//            if (result.Succeeded)
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            else
//            {
//                return View(registerUser);
//            }
//        }

//    }
//}