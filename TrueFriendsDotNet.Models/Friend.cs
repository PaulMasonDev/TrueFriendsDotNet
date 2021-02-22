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
        [Display(Name="Friend Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
