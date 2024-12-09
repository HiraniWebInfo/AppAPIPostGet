using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9M.Entity.Models
{
    public class tblUrlList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ReqType { get; set; } // GET,POST,PUT,PATCH,DELETE
        public string ReqJson { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual List<tblHeaders>? Headers { get; set; }
        public virtual List<tblParameters>? Parameters { get; set; }
    }
}
