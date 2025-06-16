using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.Models
{
    [PrimaryKey("CategoryID")]
    internal class Category
    {
        public int CategoryID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public int Order { get; set; }
        public bool Status { get; set; }
        //[InverseProperty("Category")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
