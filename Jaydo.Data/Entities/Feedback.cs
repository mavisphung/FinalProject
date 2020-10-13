using System;
using System.Collections.Generic;
using System.Text;

namespace Jaydo.Data.Entities
{
    public class Feedback
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
