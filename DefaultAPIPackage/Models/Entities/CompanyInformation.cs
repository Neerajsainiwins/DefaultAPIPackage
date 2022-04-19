using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAPIPackage.Models.Entities
{
    public class CompanyInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ContactId { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string CompanyName { get; set; }
        public int CompanyTypeId { get; set; }
        public int CountryId { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string ZipCode { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }
        public int StateId { get; set; }
        public string CompanyMainLineNo { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string BusinessEmail { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string DirectLineNo { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string MobileNo1 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string MobileNo2 { get; set; }
    }
}
