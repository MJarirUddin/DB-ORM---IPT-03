using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IPT03
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public string ClientName { get; set; }
        public Guid SalesId { get; set; }
        public Sales sales { get; set; }
    }
}
