using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollboothServer
{
    public class Tollbooth
    {
        private static readonly object m_lock = new object();
        private static int m_nextTollboothId = 1;

        private decimal COST = 0.50m;
        public int Id { get; private set; }
        public int Cars { get; private set; }
        public decimal Cash { get; private set; }

        public Tollbooth()
        {
            lock(m_lock)
            {
                Id = m_nextTollboothId++;
            }
            Reset();
        }

        public void Reset()
        {
            Cars = 0;
            Cash = 0.0m;
        }

        public void PayingCar()
        {
            Cars++;
            Cash += COST;
        }

        public void NonPayingCar() => Cars++;

        public override string ToString() => $"{Id,4}| Cars: {Cars,4}, Cash: {Cash,9:C2}";
    }
}
