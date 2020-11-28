using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerServiceModels.Models.EntitiesMongo
{
    public class Log
    {
        public DateTime Time { get; set; }
        public string Name { get; set; }
        public int? Index { get; set; }
    }
}
