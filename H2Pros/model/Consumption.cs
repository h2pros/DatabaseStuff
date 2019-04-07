using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace H2Pros.model
{
    public class Consumption
    {
        public int id { get; set; }
        public DateTime dateCreated { get; set; }
        public int coldWaterFlow { get; set; }
        public int hotWaterFlow { get; set; }

        [ForeignKey("User")]
        public User Usercpr { get; set; }
    }
}
