using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Entities.Json
{
    public class Party
    {
        public int Id { get; set; }

        public string NameShort { get; set; }

        public string NameLong { get; set; }
    }
}
