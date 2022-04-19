using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAPIPackage.Models.Entities
{
    public class PersonalInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int CompanyId { get; set; }
        public int CountryId { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Address { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string ZipCode { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string City { get; set; }
        public int StateId { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string PersonalNo1 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string PersonalNo2 { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string HomePhoneNo { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string PersonalEmail { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string LinkedIn { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
