using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {

        public int Planeid { get; set; }

        public PlaneType PlaneType { get; set; }
        public int Capacity { get; set; }

        public DateTime ManufactureDate { get; set; }


       

        #region java
        //private int capacity;
        //public int GetCapacity { get { return capacity; } }
        //public void SetCapacity(int value) { this.capacity = value; }
        #endregion
    }
}
