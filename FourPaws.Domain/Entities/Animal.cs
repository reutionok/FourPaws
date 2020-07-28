using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPaws.Domain.Entities
{
    public class Animal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string Contacts { get; set; }
        public int idCategory { get; set; }
        public Category Category { get; set; }
        public byte[] MainImage { get; set; }
        public string MainImageMimeType { get; set; }
        public byte[] Image1 { get; set; }
        public string ImageMimeType1 { get; set; }
        public byte[] Image2 { get; set; }
        public string ImageMimeType2 { get; set; }
    }
}
