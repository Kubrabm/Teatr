using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Teatr.Models
{
    public class TeatrHall : Entity
    {
        public TeatrHall[] TeatrHalls { get; set; } = new TeatrHall[5];
        public override string ToString()
        {
            return $"{TeatrHalls[5]}"+"\n";
        }
    }

}
