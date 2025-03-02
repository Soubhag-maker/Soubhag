using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SOUBHAG.Model
{
    public class Usr0050Model
    {
        [Key]
        public long RoleId { get; set; }
        public int FkCompId { get; set; }
        public string RoleName { get; set; }
        public int FkFieldIdUserCategory { get; set; }
        public int Active { get; set; }
        public int? CrtdBy { get; set; }
        public DateTime? CrtdOn { get; set; }
        public int? MdfdBy { get; set; }
        public DateTime? MdfdOn { get; set; }
        public int? RecStatus { get; set; }
        public string UserCategory { get; set; }
        public string CompCode { get; set; }
        public string CompName { get; set; }
        public String StrCrtdBy { get; set; }
        public String StrCrtdOn { get; set; }
        public String StrMdfdBy { get; set; }
        public String StrMdfdOn { get; set; }
    }
}
