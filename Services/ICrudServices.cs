using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teatr.Models;

namespace Teatr.Service
{
    internal interface ICrudServices
    {
        void Show(Entity entity);
        void Choose(int Id);
        void buy(Entity entity);
        void Update(int Id,Entity entity);
        void Delete(int Id);
        Entity GetEntity(int Id);
        Entity[] GetAll();
    }
}
