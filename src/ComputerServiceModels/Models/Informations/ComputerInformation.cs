using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerServiceModels.Models.Informations
{
    public class ComputerInformation
    {
        public int ComputerId { get; set; }
        public string Cpu { get; set; }
        public int Ram { get; set; }
        public string Gpu { get; set; }
        public string Case { get; set; }
        public int Psu { get; set; }
        public string Motherboard { get; set; }
        public string Os { get; set; }
    }
}
