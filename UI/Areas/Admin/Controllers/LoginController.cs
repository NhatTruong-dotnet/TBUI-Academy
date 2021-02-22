using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using DTO;


namespace UI.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        UserBusiness userBusiness = new UserBusiness();
        // GET: Admin/Login
        public ActionResult Index()
        {
            UserDTO user = new UserDTO();
            return View(user);
        }

        [HttpPost]
        public ActionResult Index(UserDTO userFromUI)
        {
            if (ModelState.IsValid)
            {
                UserDTO user = userBusiness.GetUserWithUsernameAndPassword(userFromUI);
                if (user.ID != 0)
                {
                    UserStatic.UserID = user.ID;
                    UserStatic.isAdmin = user.isAdmin;
                    UserStatic.Namesurname = user.Imagepath;
                    UserStatic.Imagepath = user.Imagepath;
                    LogBusiness.AddLog(1, "Login", 12);
                    return RedirectToAction("Index", "Post");
                }
                else return View();
            }
            return View(userFromUI);
        }
    }

}