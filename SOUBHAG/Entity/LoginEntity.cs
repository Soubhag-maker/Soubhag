using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace SOUBHAG.Entity
{
    public class LoginEntity
    {
        [Key]
        public int UserId { get; set; }
        public string UserNam { get; set; }
        public string UserLgnPwd { get; set; }
        public string UserTrnPwd { get; set; }
        public int FkFieldIdUserGroup { get; set; }
        public int FkFieldIdUserType { get; set; }
        public int? FkCompIdForEmployee { get; set; }
        public int? FkEmpId { get; set; }

       
        public string ExternalUserName { get; set; }
        public int? FkCompId { get; set; }
        public DateTime ValidUpTo { get; set; }
        public int PortalUser { get; set; }
        public long? FkRoleId { get; set; }
        public int Active { get; set; }
        public string Remarks { get; set; }
        public int? CrtdBy { get; set; }
        public DateTime? CrtdOn { get; set; }
        public int? MdfdBy { get; set; }
        public DateTime? MdfdOn { get; set; }
        public int? RecStatus { get; set; }
      

    }
}
