using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComputerServiceModels.Models.Informations
{
    public class OwnerInformation
    {
        public int OwnerId { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
}
