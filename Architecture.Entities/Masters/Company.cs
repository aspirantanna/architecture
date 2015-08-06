using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Entities.Masters
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        [Required]
        [Display(Name="Company Name")]
        public string CompanyName { get; set; }
        [Display(Name="Short Name")]
        public string ShortName { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [RegularExpression(@"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$", ErrorMessage="Please Enter a valid Website")]
        public string Website { get; set; }
        [Display(Name="PF Regn. No")]
        public string PFRegnNo { get; set; }
        [Display(Name = "PF %")]
        public decimal PFPercentage { get; set; }
        [Display(Name = "ESIC Regn. No")]
        public string ESICRegnNo { get; set; }
        [Display(Name = "ESIC %")]
        public decimal ESICPercentage { get; set; }
        public string TAN { get; set; }
        public string PAN { get; set; }
        [Display(Name="P. Tax Regn. No")]
        public string PTaxRegnNo { get; set; }
    }
}
