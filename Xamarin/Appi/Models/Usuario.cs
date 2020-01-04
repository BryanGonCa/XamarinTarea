using System.ComponentModel.DataAnnotations;

namespace Appi.Models
{
    public enum TypeContact
    {
        Facebook,
        Email,
        PhoneN0umber,

    }
    public class Usuario
    {
        [Key]
        public int PhoneID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public TypeContact Type { get; set; }
    }
}