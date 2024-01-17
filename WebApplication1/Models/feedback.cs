using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Core.Models
{
    public class feedback : IEntity

    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = "";
        [Required]
        public int Feedback { get; set; }
        public string Name { get; set; } = "";
        public string Url { get; set; } = "";


    }

}
