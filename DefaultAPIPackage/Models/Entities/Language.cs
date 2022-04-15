using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DefaultAPIPackage.API.Models
{
    public class Language
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string LanguageName { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Direction { get; set; }
    }
}
