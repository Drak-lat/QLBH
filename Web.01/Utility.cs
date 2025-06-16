    using QLBH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH
{
    internal class Utility
    {
        static public Employee? Employee { get; set; }
        static public string ImagePath =
        Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Images\";
    }
}
