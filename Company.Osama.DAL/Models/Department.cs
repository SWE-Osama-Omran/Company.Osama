using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Osama.DAL.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public String Code { get; set; }
        public String Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
