using Jaydo.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jaydo.Data.Entities
{
    public class Category
    {

        public int Id { get; set; }
        public int SortOrder { get; set; }
        //cho phép null thì thêm ? vào
        public int? ParentId { get; set; }
        public Status Status { get; set; }
    }
}
