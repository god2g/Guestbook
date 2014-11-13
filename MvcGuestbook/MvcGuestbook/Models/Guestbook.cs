using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcGuestbook.Models
{
    public class Guestbook
    {
        [Key]
        public int No { get; set; }
        [Required]
        [MaxLength(5)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedOn { get; set; }
    }
}