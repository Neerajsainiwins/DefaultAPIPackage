using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DefaultAPIPackage.API.Models
{
    public class TextResourceKeyValue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string TextResourceKeyValueName { get; set; }
        public int TextResourceKeyId { get; set; }
    }
}
