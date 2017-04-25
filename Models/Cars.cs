using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DbContextWebTest.Models
{
    public class Cars
    {
        [Key]
        public int ID { get; set; }
        public string CarName { get; set; }
        public bool IsChecked { get; set; }
    }
}