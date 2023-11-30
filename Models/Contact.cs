using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        // user ID from AspNetUser table.
        //here the fields may hold null or string value (indicated by string?)
        public string? OwnerID { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        public ContactStatus Status { get; set; }


    }

    //fixed set of values for contact status
    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}