using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormMultipleInsert.Models;

namespace FormMultipleInsert.Controllers
{
    public class ViewModelUserEmailController : Controller
    {
        // GET: ViewModelUserEmail

        [HttpGet]
        public ActionResult Add(int id = 0)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(ViewModelUserEmail viewModel)
        {
            using (UserRegistrationEntities DbModel = new UserRegistrationEntities())
            {
                User userModel = new User()
                {
                    Username = viewModel.Username,
                    Password = viewModel.Password,
                    IsAdmin = viewModel.IsAdmin
                };

                DbModel.Users.Add(userModel);
                DbModel.SaveChanges();

                User userId = DbModel.Users.FirstOrDefault(x => x.Username == viewModel.Username);

                Email emailModel = new Email()
                {
                    UserId = userId.Id,
                    EmailAddress = viewModel.EmailAddress,
                    User = userId 
                };

                DbModel.Emails.Add(emailModel);
                DbModel.SaveChanges();
            }
                

            return View();
        }
    }
}