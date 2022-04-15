using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DefaultAPIPackage.API.Models
{
    public class TextResourceKey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string TextResourceKeyName { get; set; }
        public int TextResourceCategoryId { get; set; }
    }
}
