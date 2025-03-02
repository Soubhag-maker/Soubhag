using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SOUBHAG.Entity
{
    public class Usr0051Entity
    {
        [Key]
        public long RolePageId { get; set; }
        public long FkRoleId { get; set; }
        //public int FkMenuId { get; set; }
        public int ViewPermission { get; set; }
        public int? ViewOwn { get; set; }
        public int? ViewOther { get; set; }
        public int SavePermission { get; set; }
        public int? SaveOwn { get; set; }
        public int? SaveOther { get; set; }
        public int DeletePermission { get; set; }
        public int? DeleteOwn { get; set; }
        public int? DeleteOther { get; set; }
        public int PrintPermission { get; set; }
        public int? PrintOwn { get; set; }
        public int? PrintOther { get; set; }
        public int FkMenuID { get; set; }
    }
}
