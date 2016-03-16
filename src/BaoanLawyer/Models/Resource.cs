using System;
using System.ComponentModel.DataAnnotations;

namespace BaoanLawyer.Models
{
    public class Resource
    {
        public long Id { get; set; }

        [MaxLength(128)]
        public string Title { get; set; }

        public DateTime Time { get; set; }

        public long DownloadCount { get; set; }
    }
}
