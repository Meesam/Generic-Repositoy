using System.Linq;
using System.Web.Mvc;
using DomainService.Abstraction;
using  MVCGenericRepositoryPettern.Models;

namespace MVCGenericRepositoryPettern.Controllers
{
    public class UsersViewController : Controller
    {
        private readonly IUserRepository _iUserRepository;
        public UsersViewController(IUserRepository iUserRepository)
        {
            _iUserRepository = iUserRepository;
        }

        public ActionResult ShowAllusers()
        {
            var userviewmodel = new UserViewModel
            {
                Userslist = _iUserRepository.GetAll().ToList()
            };
            return View(userviewmodel);
        }

        public ActionResult AddNew()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveUsers(UserViewModel model)
        {
            _iUserRepository.Add(model.Users);
            _iUserRepository.Save();
            return RedirectToAction("ShowAllusers");
        }

        public ActionResult Search(UserViewModel model)
        {
            var userviewmodel = new UserViewModel
            {
                Userslist = _iUserRepository.MySearch(model.Users).ToList()
            };
            return RedirectToAction("ShowAllusers", userviewmodel);
        }

    }
}