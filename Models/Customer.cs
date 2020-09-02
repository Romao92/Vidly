using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Compilation;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribdedToNewsletter { get; set; }
        public MemberShipType MemberShipType { get; set; }

        [Display(Name="Membership Type")]
        public byte MemberShipTypeId { get; set; }

        [Display(Name="Date Of Birth")]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }
    }
}