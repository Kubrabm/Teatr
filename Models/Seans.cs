using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Teatr.Models
{
    public class Seans:Entity
    {
        public Seans[] Seanses { get; set; } = new Seans[5];
        public int SeansTime { get; set; }
        public int SeansPrice { get; set; }
        public override string ToString()
        {
            return $"{Seanses[5]}{SeansTime}+\"n\"{SeansPrice}+\"n\"";
        }
    }
}