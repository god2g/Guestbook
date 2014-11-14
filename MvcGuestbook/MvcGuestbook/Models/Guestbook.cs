using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcGuestbook.Models
{
    public class Guestbook
    {
        [Key]
        public int No { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}