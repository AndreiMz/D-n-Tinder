using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DnTinder.Models;

namespace DnTinder.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public string Allow(string username, string password)
        {
         return "penis";
        }
    }
}