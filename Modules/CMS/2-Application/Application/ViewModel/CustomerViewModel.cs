using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.CustomerAggregate.Models;

namespace Application.ViewModel
{
    public class CustomerViewModel
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "The E-mail is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        public string FirstName { get;  set; }

        [Required(ErrorMessage = "The E-mail is Required")]
        [MinLength(2)]
        [MaxLength(100)]
        public string LastName { get;  set; }

        [Required(ErrorMessage = "The E-mail is Required")]
        public string PhoneNumber { get;  set; }

        [Required(ErrorMessage = "The E-mail is Required")]
        public string NationalCode { get;  set; }

        public Address Address { get; set; }
    }
}
