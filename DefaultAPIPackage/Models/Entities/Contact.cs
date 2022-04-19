using DefaultAPIPackage.Models.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultAPIPackage.Models.Entities
{
    public class Contact : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string MiddleName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string LastName { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        public string Title { get; set; }    
        public int TypeId { get; set; }    
        public int TeamKnowledgeId { get; set; }
        [Column(TypeName = "nvarchar(1000)")]
        public string Notes { get; set; }
        public int TagsId { get; set; }    
    }
}
