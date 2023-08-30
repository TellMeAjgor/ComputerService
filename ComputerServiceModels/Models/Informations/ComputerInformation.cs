using ComputerServiceModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServiceModels.Models.Informations
{
    public class ComputerInformation
    {
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
