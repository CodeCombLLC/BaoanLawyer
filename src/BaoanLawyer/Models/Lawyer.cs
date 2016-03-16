using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CodeComb.AspNet.Upload.Models;

namespace BaoanLawyer.Models
{
    public class Lawyer
    {
        public long Id { get; set; }

        [MaxLength(16)]
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Resume { get; set; }

        public int PRI { get; set; }

        [ForeignKey("Avatar")]
        public Guid? AvatarId { get; set; }

        public File Avatar { get; set; }

        public virtual ICollection<Case> Cases { get; set; } = new List<Case>();
    }
}
