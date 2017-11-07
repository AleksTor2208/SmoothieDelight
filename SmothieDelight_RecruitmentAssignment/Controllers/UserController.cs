using SmothieDelight_RecruitmentAssignment.Models;
using System.Web.Mvc;
using System;

namespace SmothieDelight_RecruitmentAssignment.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext _context;

        public UserController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult New(UserInfo user)
        {
            if (UserValidation(user))
            { 
                var newUser = new UserInfo
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName ?? null,
                    Email = user.Email
                };
                _context.UsersInfo.Add(newUser);
                _context.SaveChanges();
                return Redirect("/Home/Index");
            }
            return Redirect("New");
        }

        private bool UserValidation(UserInfo user)
        {
            return user.FirstName != null
                && user.Email != null;
        }
    }
}