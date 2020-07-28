using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPaws.Domain.Entities
{
    public class Category
    {
        public int CategoryId {get; set;}
        public string Name { get; set; }
        public List<Animal> Animals { get; set; }

    }
}
