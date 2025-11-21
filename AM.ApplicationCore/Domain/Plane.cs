using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    //public enum PlaneType {Airbus, Boeing}
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public ICollection <Flight> Flights { get; set; }
        //public Plane(PlaneType pt, int capacity, DateTime date ) { 
        //    this.PlaneType = pt;
        //    this.Capacity = capacity;
        //    this.ManufactureDate = date;
        //}
        public override string ToString()
        {
            return "Capacity :" + Capacity
                + "ManufactureDate :" + ManufactureDate
                + "Planetype" + PlaneType;
            }
    }
}
