using System;
using System.Collections.Generic;
using System.Text;

namespace Jaydo.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int Stock { get; set; }
        public DateTime DateCreated { get; set; }
        public int UnitPrice { get; set; }



    }
}
