using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodeComb.AspNet.Upload.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BaoanLawyer.Models
{
    public class User : IdentityUser
    {
        [MaxLength(32)]
        public string Name { get; set; }

        [ForeignKey("Avatar")]
        public Guid? AvatarId { get; set; }

        public File Avatar { get; set; }
    }
}
