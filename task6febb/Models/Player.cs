using System;
using System.Collections.Generic;

namespace task6febb.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public int? JerseyNo { get; set; }
        public string? Position { get; set; }
        public string? Team { get; set; }
    }
}
