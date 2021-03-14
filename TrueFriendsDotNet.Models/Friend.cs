using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueFriendsDotNet.Models
{
    public class Friend
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="First Name")]
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Display(Name="Last Name")]
        [MaxLength(50)]
        public string LastName { get; set; }
    }
}
