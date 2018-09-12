using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NorbitsChallenge.Bll;

namespace NorbitsChallenge.Models
{
    public class HomeModel
    {
        public string CompanyName { get; set; }
        public int CompanyId { get; set; }
        public int? TireCount { get; set; }
        public List<Car> Cars { get; set; }
    }
}
