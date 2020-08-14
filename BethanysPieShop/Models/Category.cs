using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class Category
    {
        public int CategoryId { get; internal set; }
        public string CategoryName { get; internal set; }
        public string Description { get; internal set; }
    }
}
