using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
namespace lab3.Models
{
    public class WebUser: IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
    }    
}
