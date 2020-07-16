using System;
using System.ComponentModel.DataAnnotations;

namespace SQLite.Models
{
    public class Buy
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public double Sum { get; set; }
        [MaxLength(20)]
        public string Date { get; set; } = DateTime.Now.ToString("d");
    }
}
