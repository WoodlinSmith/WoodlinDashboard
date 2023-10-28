using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLib.Models.Data
{
    public class GameRecord
    {
        public GameRecord()
        {

        }

        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public decimal RegularPrice { get; set; }
        public decimal SalePrice { get; set; }
        public double TotalDiscount { get; set; }

    }
}
