using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Core;

namespace WebApplication1.Core.Models
{
    public class Category : IEntity
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = "";
        [Required]
        public string Comment { get; set; } = "";
        public string Name { get; set; } = "";
        public string Url { get; set; } = "";

    }
 
}

