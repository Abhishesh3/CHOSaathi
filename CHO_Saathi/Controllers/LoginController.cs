using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CHO_Saathi.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Web;
using System.Text;
using CHO_Saathi.Common;

namespace CHO_Saathi.Controllers
{
    public class LoginController : Controller
    {

        private readonly ApplicationDBContext _context;

        public LoginController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: LoginController
        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.Captcha = RandomString(4);
            return View();
        }


        //// POST: Login/User Check
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(User User)
        {
            try
            {

                string Username = User.Username;

                string Password = User.Vcode;

                Password = Password.Replace(User.Password, "");

                byte[] decryptedPasswrd = Convert.FromBase64String(Password);

                Password = Encoding.UTF8.GetString(decryptedPasswrd);

                if (Password.Substring(7, 8).Contains("H"))
                    Password = Password.Substring(8);

                byte[] decryptedPasswrd1 = Convert.FromBase64String(Password);

                Password = Encoding.UTF8.GetString(decryptedPasswrd1);

                if (Username != null && Password != null)
                {
                    var chkUser = _context.Users.Where(m => m.Username == User.Username && m.IsDeleted == 0 && m.IsActive == true).FirstOrDefault();

                    if (chkUser != null && chkUser.Username == User.Username && chkUser.Username.Equals(User.Username))
                    {
                        if (_context.Users.Where(m => m.Username == User.Username && m.IsDeleted == 0 && m.IsActive == true).Count() > 0)
                        {
                            var user = Authenticate(User.Username, Password);
                            if (user == null)
                            {
                                TempData["message"] = "Invalid Username or Password. Please try again.";
                                ViewBag.Captcha = RandomString(4);
                                return View();
                            }
                            else
                            {

                                HttpContext.Session.SetString("UserName", user.Username);
                                HttpContext.Session.SetString("Name", user.Name);
                                HttpContext.Session.SetString("EmailId", user.EmailId);
                                HttpContext.Session.SetString("RoleId", user.RoleId.ToString());
                                HttpContext.Session.SetString("UserId", user.UserId.ToString());
                                HttpContext.Session.SetString("SirjanID", "0");
                                // HttpContext.Session.SetString("MenuId", "1");

                                User ust = _context.Users.Where(p => p.UserId == user.UserId && p.IsActive == true).FirstOrDefault();

                                if (ust.NoofLogins == null)
                                {
                                    ust.NoofLogins = 1;
                                }
                                else
                                {
                                    ust.NoofLogins = ust.NoofLogins + 1;
                                }
                                 ust.LastLoggedIn = System.DateTime.Now;

                                _context.Update(ust);
                                _context.SaveChanges();

                                if (Convert.ToInt32(HttpContext.Session.GetString("RoleID")) == 12) //PMH-COP
                                {
                                    return RedirectToAction("Index", "PatientReport");
                                }
                                else
                                {
                                    return RedirectToAction("Index", "PatientReport");
                                }

                                //return RedirectToAction("Index", "DashboardMap");
                                //return RedirectToAction("ANCDashboard", "ANCDashboard");

                            }

                        }
                        else
                        {
                            TempData["message"] = "Invalid Username or Password. Please try again.";
                            ViewBag.Captcha = RandomString(4);
                            return View();
                        }
                    }
                    else
                    {
                        TempData["message"] = "Invalid Username or Password. Please try again.";
                        ViewBag.Captcha = RandomString(4);
                        return View();
                    }
                }
                else
                {
                    TempData["message"] = "Invalid Username or Password. Please try again.";
                    ViewBag.Captcha = RandomString(4);
                    return View();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        public User Authenticate(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return null;

            var user = _context.Users.SingleOrDefault(x => x.Username == username && x.IsDeleted == 0);

            // check if username exists
            if (user == null)
                return null;

            //check if password is correctpassword
            var passwordHashed = CommonController.CreatePasswordHash(password);
            if (user.Password != passwordHashed)
                return null;
            //var CHKpassword = _context.MstUser.SingleOrDefault(x => x.Password == passwordHashed);
            //if (CHKpassword == null)
            //    return null;

            // authentication successful
            return user;
        }





        [AllowAnonymous]
        public ActionResult GenerateCaptcha()
        {
            return Json(RandomString(4));
        }


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            //string upperChar = "ABCDEFGHJKMNOPQRSTUVWXYZ";
            //string lowerChar = "ABCDEFGHJKMNOPQRSTUVWXYZ".ToLower();
            string numericChar = "0123456789";
            //string chars = upperChar + lowerChar + numericChar;
            string chars = numericChar;
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }



        [HttpGet]
        public IActionResult Logout()
        {
            // Clear session data
            HttpContext.Session.Clear();

            // Redirect to login page
            return RedirectToAction("Login", "Login");
        }



        public ActionResult Index()
        {
            return View();
        }

        // GET: LoginController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
