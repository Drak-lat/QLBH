using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QLBH.Models
{
    [PrimaryKey("OrderID")]
    internal class Order
    {
        public long OrderID { get; set; }
        [Column(TypeName = "Date")]
        public DateTime OrderDate { get; set; }
        public TimeSpan OrderTime { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? ReceiveDate { get; set; }
        public TimeSpan? ReceiveTime { get; set; }
        [StringLength(250)]
        public string ReceiveAddress { get; set; }
        public long EmployeeID { get; set; }
        public byte ProgressID { get; set; } = 1;
        public long CustomerID { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Progress Progress { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
