using Microsoft.AspNetCore.Identity;
using System;

namespace DnTinder.Areas.Identity.Data
{
    public class User : IdentityUser
    {
        [PersonalData]
        public string Name {get; set;}
        
        [PersonalData]
        public string Surname {get; set;}

    }
}