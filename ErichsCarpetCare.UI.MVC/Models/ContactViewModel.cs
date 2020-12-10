using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ErichsCarpetCare.UI.MVC.Models
{
    public class ContactViewModel
    {
        public bool Carpet { get; set; }
        public bool Tile { get; set; }
        public bool Upholstery { get; set; }
        public bool Rug { get; set; }
        public bool Other { get; set; }

        [Display(Name = "Odor Neutralization")]
        public bool Odor { get; set; }

        [Display(Name = "Carpet Protector")]
        public bool CarpetProtector { get; set; }

        [Display(Name = "Anti-Allergin Cleaner")]
        public bool AntiAllergin { get; set; }



        [Required(ErrorMessage = "* Your First Name is required.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "* Your Last Name is required.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "* Your Email is required.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "* Your Phone Number is required.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "* Service Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "* Your Zip Code is required.")]
        public string ZipCode { get; set; }

        [Display(Name = "Preferred Date (optional)")]
        [DisplayFormat(DataFormatString = "{0:dd/MMM/yyyy}")]
        public DateTime? RequestedDate { get; set; }

        //Had to change from bool to string to properly capture value from droplist
        [Required(ErrorMessage = "* Please choose an option.")]
        [Display(Name = "Commercial or Residential?")]
        public string IsCommercial { get; set; }

        [Required(ErrorMessage = "* Please choose an option.")]
        [Display(Name = "How'd you hear about us?")]
        public string Referral { get; set; }

        [Display(Name = "Who referred you? (optional)")]
        public string ReferralSource { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

    }
}