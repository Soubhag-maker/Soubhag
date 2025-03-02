using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SOUBHAG.Entity
{
    public class ba1111Entity
    {
        [Key]
        public int UserDtlsId { get; set; }
        public int FkUserId { get; set; }
        public int FkCompId { get; set; }
        public long? FkRoleId { get; set; }
        public int CompId { get; set; }
        public int RoleId { get; set; }
        public int? FkBranchId { get; set; }
        public string CompNam { get; set; }
        public string RoleName { get; set; }
        public string strBranchIds { get; set; }
        public string Branches { get; set; }
        public string BrancheIds { get; set; }
        public string DefaultBranch { get; set; }
        public int DefaultBranchId { get; set; }

        public string StrBranch { get; set; }
    }
}
