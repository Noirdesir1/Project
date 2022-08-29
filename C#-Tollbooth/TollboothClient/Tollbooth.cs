using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollboothClient
{
    public class Tollbooth
    {
        public int Id { get; }
        public int Cars { get; }
        public decimal Cash { get; }

        public Tollbooth(int TollboothId, int Cars, decimal Cash)
        {
            this.Id = TollboothId;
            this.Cars = Cars;
            this.Cash = Cash;
        }
    }
}
