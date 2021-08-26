using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new AirportDBEntities())
            {
                var temp = ctx.Airport.Where(e => e.Name.Equals("Copenhagen")).ToList();
                var temp1 = ctx.Company.Where(e => e.CompanyName.Equals("SAS")).ToList();
                var temp2 = ctx.Route.Where(e => e.WhereTo.Equals("Copenhagen")).ToList();
            }
        }
    }
}
