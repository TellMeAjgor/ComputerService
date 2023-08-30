using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceModels.Models.Entities
{
    public class UserComputers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserComputersId { get; set; }
        public Guid UserId { get; set; }
        public Guid ComputerId { get; set; }
        public virtual User User { get; set; }
        public virtual Computer Computer { get; set; }
    }
}
