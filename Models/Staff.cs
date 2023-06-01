using System;
using System.Collections.Generic;

namespace OOO_debili.Models
{
    public partial class Staff
    {
        public int Id { get; set; }
        public string Pilots { get; set; } = null!;
        public string Attendants { get; set; } = null!;
        public string FlightEngineer { get; set; } = null!;
        public string СoDriver { get; set; } = null!;
    }
}
