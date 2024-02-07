using System.ComponentModel.DataAnnotations;

namespace MO_Al.Models
{
    public class tbPerson
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }  
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string status { get; set; }
    }
}
