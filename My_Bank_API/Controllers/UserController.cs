using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Bank_API.DataAccess;
using My_Bank_API.Models;


namespace My_Bank_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private MyBankDbContext _db;

        public UserController(MyBankDbContext db)
        {
            _db = db;
        }

        //GET /api/User
        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
            var users = _db.Users;
            return users;
        }

        [HttpPost]
        public void CreateUser(string FName, string LName, string EAddress, 
            string UPassword)
        {
            User newUser = new User();
            newUser.FirstName = FName;
            newUser.LastName = LName;
            newUser.EmailAddress = EAddress;
            newUser.UserPassword = UPassword;
            _db.Add(newUser);
            _db.SaveChanges();
        }
    }
}