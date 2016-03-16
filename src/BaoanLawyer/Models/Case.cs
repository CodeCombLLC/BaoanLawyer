using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BaoanLawyer.Models
{
    public enum CaseType
    {
        民事案件,
        行政案件,
        刑事案件
    }

    public class Case
    {
        public long Id { get; set; }

        public DateTime Time { get; set; }

        [MaxLength(128)]
        public string Title { get; set; }

        public string Description { get; set; }

        public CaseType Type { get; set; }

        public bool Private { get; set; }

        public virtual ICollection<LawyerCase> LawyerCases { get; set; } = new List<LawyerCase>();
    }
}
