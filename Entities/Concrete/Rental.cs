using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rental:IEntity
    {
        public int ID { get; set; }
        public int CarID { get; set; }
        public int CustomerID { get; set; }
        public string RentDate { get; set; }
        public string ReturnDate { get; set; }

    }
}
