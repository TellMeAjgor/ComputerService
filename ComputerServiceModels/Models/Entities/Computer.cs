using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceModels.Models.Entities
{
    public class Computer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ComputerId { get; set; }
        public string Processor { get; set; }
        public string Ram { get; set; }
        public string GraphicsCard { get; set; }
        public string Case { get; set; }
        public string PowerSuply { get; set; }
        public string Motherboard { get; set; }
        public string OperaionSystem { get; set; }
    }
}
