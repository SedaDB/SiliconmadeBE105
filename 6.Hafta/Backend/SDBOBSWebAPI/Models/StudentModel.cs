using System.ComponentModel.DataAnnotations;

namespace SDBOBSWebAPI.Models
{
    public class StudentModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public int Number { get; set; }
        public string ClassName { get; set; }
    }
}
