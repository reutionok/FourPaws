using FourPaws.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FourPaws.WebUI.Models
{
    public class AnimalListViewModel
    {
        public IEnumerable<Animal> Animals { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}