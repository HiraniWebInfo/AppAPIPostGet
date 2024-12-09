using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App9M.Entity.Models
{
    public class tblHeaders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string HeaderKey { get; set; }
        public string HeaderValue { get; set; }
        public string HeaderFinalValue { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public int? urlId { get; set; }
        [ForeignKey("urlId")]
        public tblUrlList? UrlList { get; set; }
    }
}
