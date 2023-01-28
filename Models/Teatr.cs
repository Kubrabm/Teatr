using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Teatr.Models
{
    public class Teatr:Entity
    {
        public Teatr[] Teatrs { get; set; } = new Teatr[10];
        public String? Adress { get; set; }
        public int TelephoneNumber { get; set; }
        public override string ToString()
        {
            return $"{Teatrs[10]}{Adress}+\"n\" {TelephoneNumber}+\"\\n\"";
        }
    }

}

