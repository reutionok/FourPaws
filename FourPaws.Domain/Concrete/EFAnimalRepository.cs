using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourPaws.Domain.Abstract;
using FourPaws.Domain.Entities;

namespace FourPaws.Domain.Concrete
{
    public class EFAnimalRepository: IAnimalRepository
    {
        EFDbContext context = new EFDbContext();

        public IEnumerable<Animal> Animals
        {
            get { return context.Animals; }
        }
        public IEnumerable<Category> Categories
        {
            get { return context.Categories; }
        }
    }
}
