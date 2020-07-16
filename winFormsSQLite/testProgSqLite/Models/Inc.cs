using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProgSqLite.Models
{
    public class Inc
    {
        public int Id { get; set; }
        public int CategoryID { get; set; }
        public string Type { get; set; }
        public decimal Sum { get; set; }
        public string Comment { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
    }
}
