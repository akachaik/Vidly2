using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidly2.Models;

namespace Vidly2.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }

    }
}
