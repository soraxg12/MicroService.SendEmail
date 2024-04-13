using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroService.SendEmail.Domain.Entities
{
    public class Email : BaseEntity
    {
        [MaxLength(60)]
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        [Required]
        public string EmailAdress { get; set; }
    }
}
