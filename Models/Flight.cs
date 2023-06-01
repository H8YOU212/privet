using System;
using System.Collections.Generic;

namespace OOO_debili.Models
{
    public partial class Flight
    {
        public int Id { get; set; }
        public string Datetime { get; set; } = null!;
        public string Destination { get; set; } = null!;
    }
}
