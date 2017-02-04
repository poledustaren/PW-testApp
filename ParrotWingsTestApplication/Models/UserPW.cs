using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ParrotWingsTestApplication.Models
{
    public class UserPw
    {
        [Key]
        public int Id { get; set; }
        public int Money { get; set; }
        public virtual List<ApplicationUser> Users { get; set; }

    }

   
}