using System.ComponentModel.DataAnnotations;
namespace Multi_PageWevAppwDB.Models
{
    public class Contact
    {
        //EF Core will configure the database to generte this value
        public int ContactID { get; set; }

        [Required(ErrorMessage ="Please enter a name.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a phone number.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an address.")]
        public string Address { get; set; } = string.Empty;

        [StringLength(100, ErrorMessage ="Note cannot exceed 100 characters.")]
        public string Note { get; set; } = string.Empty;

    }
}
