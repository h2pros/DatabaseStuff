using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H2Pros.model
{
    public class User
    {
        public User()
        {

        }
        [Key]
        public int cpr { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public ICollection<Consumption> consumptions { get; set; }
    }
}
