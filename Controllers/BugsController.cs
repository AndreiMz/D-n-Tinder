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
    public class BugsController : Controller
    {
        private readonly DnTinderContext db;

        public BugsController(DnTinderContext context){
            db = context;
        }

        [HttpPost]
        public string Report([FromBody] dynamic bug)
        {
            try{
                if(bug["ObservedBehaviour"] == null)
                {
                    throw new Exception();
                }
                Bug _temp = new Bug();
                _temp.ObservedBehaviour = bug["ObservedBehaviour"];
                _temp.ExpectedBehaviour = bug["ExpectedBehaviour"];
                _temp.ReproductionSteps = bug["ReproductionSteps"];

                db.Bugs.Add(_temp);
                db.SaveChanges();
                return "Successfully reported a bug";
            }
            catch(Exception){
                return "Something bad happened";
            }
        }

        public IEnumerable<Bug> List(){
            return db.Bugs.ToArray();
        }
    }
}