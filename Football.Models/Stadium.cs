using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football.Models
{
    public class Stadium
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public virtual Town Town { get; set; }
    }
}
