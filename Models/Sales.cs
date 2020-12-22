using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IPT03
{
    public class Sales
    {
        [Key]
        public Guid SalesId { get; set; }
        public string SalesName { get; set; }
        public string SalesType { get; set; }
    }
}
