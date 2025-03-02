using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SOUBHAG.Entity
{
    public class ba1300Entity
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpNo { get; set; }
        public List<ba1300Entity> List { get; set; }
    }
}
