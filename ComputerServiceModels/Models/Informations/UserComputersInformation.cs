using ComputerServiceModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceModels.Models.Informations
{
    public class UserComputersInformation
    {
        public Guid UserComputersId { get; set; }
        public Guid UserId { get; set; }
        public Guid ComputerId { get; set; }
        public virtual UserInformation UserInformation { get; set; }
        public virtual ComputerInformation ComputerInformation { get; set; }
    }
}
