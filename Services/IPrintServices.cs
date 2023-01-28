using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teatr.Models;

namespace Teatr.Service
{
    internal interface IPrintServices
    {
        void Print();
        void print(Entity entity);
    }
}
