using FourPaws.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPaws.Domain.Abstract
{
   public interface IAnimalRepository
    {
        IEnumerable<Animal> Animals { get; }
        IEnumerable<Category> Categories { get; }
        
    }
}
