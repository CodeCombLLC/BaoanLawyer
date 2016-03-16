using System;
using System.ComponentModel.DataAnnotations;

namespace BaoanLawyer.Models
{
    public class Information
    {
        public long Id { get; set; }

        [MaxLength(128)]
        public string Title { get; set; }

        public long CatalogId { get; set; }

        public string Content { get; set; }

        public DateTime Time { get; set; }
    }
}
