using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    [PrimaryKey("ProgressID")]
    internal class Progress
    {
        public byte ProgressID { get; set; }
        [Column(TypeName = "nchar(15)")]
        public string Name { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
