using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    [PrimaryKey("OrderDetailID")]
    internal class OrderDetail
    {
        public long OrderDetailID;
        public long OrderID { get; set; }
        public long ProductID { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        //[Column(TypeName = "decimal(18, 2)")]B
        //public decimal Amount { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}