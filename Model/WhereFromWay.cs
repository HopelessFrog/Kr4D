
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiprocessor_And_Multithreaded_Programming
{
    public class WhereFromWay
    {
        public WhereFromWay(string whereWay)
        {

            WhereWay = whereWay;
        }

        [Required]
        public int Id { get; set; }
        [Required]
        public string WhereWay { get; set; }

        public List<Trains> Trains { get; set; } = new();
    }

}
