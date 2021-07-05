using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public  class UserProductEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
        public int Count { get; set; }
    }
}
