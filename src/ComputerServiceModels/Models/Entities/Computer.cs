using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComputerServiceModels.Models.Entities
{
    public class Computer
    {
        [Key]
        public int ComputerId { get; set; }
        public string Cpu { get; set; }
        public string Ram { get; set; }
        public string Gpu { get; set; }
        public string Case { get; set; }
        public string Psu { get; set; }
        public string Motherboard { get; set; }
        public string Os { get; set; }
        public int OwnerId { get; set; }
        public virtual Owner Owner { get; set; }
    }
}
