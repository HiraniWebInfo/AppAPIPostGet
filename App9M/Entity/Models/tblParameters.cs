using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App9M.Entity.Models
{
    public class tblParameters
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string @Type { get; set; } //Static, Capture
        public string Source { get; set; } //Header, Body
        public string PathValue { get; set; } //JsonPath abc.xyz[n].pqrs OR static value
        public string FinalValue { get; set; } //Derived value
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? urlId { get; set; }
        [ForeignKey("urlId")]
        public tblUrlList? UrlList { get; set; }
    }
}
