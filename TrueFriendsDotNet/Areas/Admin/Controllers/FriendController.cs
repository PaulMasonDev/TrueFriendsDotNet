using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using TrueFriendsDotNet.DataAccess.Repository.IRepository;
using TrueFriendsDotNet.Models;

namespace TrueFriendsDotNet.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FriendController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public FriendController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Friend friend = new Friend();
            if(id == null)
            {
                //Add Friend(create)
                return View(friend);
            }
            //Edit Friend
            friend = _unitOfWork.Friend.Get(id.GetValueOrDefault());
            if (friend == null)
            {
                return NotFound();
            }
            //Return the friend the was found with the getValueOrDefault
            return View(friend);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Upsert(Friend friend)
        {
            if (ModelState.IsValid)
            {
                if(friend.Id == 0)
                {
                    _unitOfWork.Friend.Add(friend);
                }
                else
                {
                    _unitOfWork.Friend.Update(friend);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(friend);
        }
        #region API Calls

        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Friend.GetAll();
            return Json(new { data = allObj });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Friend.Get(id);
            var name = "" + objFromDb.FirstName + " " + objFromDb.LastName;
            if(objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting " + name });
            }
            else
            {
                _unitOfWork.Friend.Remove(objFromDb);
                _unitOfWork.Save();
                return Json(new { success = true, message = "Removed " + name + " successfully" });
            }
        }
        #endregion
    }


}
