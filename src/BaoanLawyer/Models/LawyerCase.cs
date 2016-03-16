using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaoanLawyer.Models
{
    public class LawyerCase
    {
        [ForeignKey("Lawyer")]
        public long LawyerId { get; set; }

        public virtual Lawyer Lawyer { get; set; }

        [ForeignKey("Case")]
        public long CaseId { get; set; }

        public virtual Case Case { get; set; }
    }
}
