using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SOUBHAG.Model
{
    public class ba1300Model
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpNo { get; set; }
        public List<ba1300Model> List { get; set; }
    }
}
