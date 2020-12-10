
using System.ComponentModel.DataAnnotations;


namespace ErichsCarpetCare.Data.EF
{
    class CustomerMetadata
    {
        [Required]
        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Required]
        [Display(Name = "Receive Reimders for this customer?")]
        public bool? ReceiveReminders { get; set; }

        [UIHint("Multilinetext")]
        public string Notes { get; set; }
    }

    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customers
    {
        [Display(Name = "Name")]
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
    }
}
