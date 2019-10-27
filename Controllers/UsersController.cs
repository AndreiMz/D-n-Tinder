using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DnTinder.Areas.Identity.Data;
using DnTinder.Models;

namespace DnTinder.Controllers
{
    public class UsersController : Controller
    {
        private readonly DnTinderContext db;

        public UsersController(DnTinderContext context){
            db = context;
        }

        [HttpGet]
        public string Allow(string username, string password)
        {
         return "penis";
        }

        public IEnumerable<Preference> Dbtest(){
            return db.Preferences.ToArray();
        }
    }
}