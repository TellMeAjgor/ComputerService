using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComputerServiceModels.Models.Informations
{
    public class OwnerInformation
    {
        public int OwnerId { get; set; }
        public string Email { get; set; }
        [EmailAddress]
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
