using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9M.Entity.Models
{
    public class tblParameters
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string @Type { get; set; }
        public string Source { get; set; }
        public string PathValue { get; set; }
        public string FinalValue { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? urlId { get; set; }
        [ForeignKey("urlId")]
        public tblUrlList? UrlList { get; set; }
    }
}
