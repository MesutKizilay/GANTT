using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Dependency:IEntity
    {
        public int Id { get; set; }
        public int PredecessorId { get; set; }
        public int SuccessorId{ get; set; }
        public int Type { get; set; }
    }
}