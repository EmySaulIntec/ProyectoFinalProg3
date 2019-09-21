using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.Models
{

    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; private set; } = DateTime.Now;
    }
}
