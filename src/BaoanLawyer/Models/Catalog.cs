using System.ComponentModel.DataAnnotations;

namespace BaoanLawyer.Models
{
    public class Catalog
    {
        public long Id { get; set; }

        [MaxLength(32)]
        public string Title { get; set; }

        public int PRI { get; set; }
    }
}
