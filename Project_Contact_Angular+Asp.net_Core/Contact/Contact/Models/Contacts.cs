using System.ComponentModel.DataAnnotations;

namespace Contact.Models
{
    public class Contacts
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
