using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SOUBHAG.Entity
{
    public class adm0001Entity
    {
        [Key]
        public int MenuID { get; set; }

       
        public string PageNameChild { get; set; }
        public int? MenuOrderNo { get; set; }
        public string IconName { get; set; }
        public int AdminFlag { get; set; }
        public int Active { get; set; }
        public int PageID { get; set; }
        public int ReffMenuId { get; set; }
        public int ApplicableForPortal { get; set; }

        public string MenuCaption { get; set; }
        public string MenuSubCaption { get; set; }
        public int? FkMenuId { get; set; }
        public int? IsModule { get; set; }
        public int? IsSubModule { get; set; }
        public int? IsFolder { get; set; }
        public int? IsPage { get; set; }
        public string PageName { get; set; }
        public string IconTag { get; set; }
        public string IconColour { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public string PageUrl { get; set; }

        public string widgetInnerHtml { get; set; }

        public int MenuId { get; set; }

        [NotMapped]
        public List<adm0001Entity> ModuleList { get; set; }

        [NotMapped]
        public List<adm0001Entity> SubModuleList { get; set; }
    }
}
