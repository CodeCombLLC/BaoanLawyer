using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaoanLawyer.Models
{
    public class Information
    {
        public long Id { get; set; }

        [MaxLength(128)]
        public string Title { get; set; }

        [ForeignKey("Catalog")]
        public long CatalogId { get; set; }

        public Catalog Catalog { get; set; }

        public string Content { get; set; }

        public DateTime Time { get; set; }

        public bool Top { get; set; }
    }
}
