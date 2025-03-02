using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SOUBHAG.Model
{
    public class ba1110Model
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

        public int? CompId { get; set; }
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

        public int FieldId { get; set; }
        public string FieldValue { get; set; }
        public string Confirm { get; set; }
        public string ConfirmTran { get; set; }
        public string EmployeeName { get; set; }
        public string FkFieldIdUserTypeDescr { get; set; }
        public string FkFieldIdUserGroupDescr { get; set; }
        public string StrValidUpTo { get; set; }

        public string StrEmployeeName { get; set; }

        public String StrCrtdBy { get; set; }
        public String StrCrtdOn { get; set; }
        public String StrMdfdBy { get; set; }
        public String StrMdfdOn { get; set; }
    }
}
