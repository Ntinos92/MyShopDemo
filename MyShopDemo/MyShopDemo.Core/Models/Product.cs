using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopDemo.Core.Models
{
    public class Product : BaseEntity
    {
        [StringLength(20)]
        [DisplayName("Product Name")]
        public string name { get; set; }
        public string description { get; set; }

        [Range(0,1000)]
        public decimal price { get; set; }
        public string category { get; set; }
        public string image { get; set; }
    }
}
