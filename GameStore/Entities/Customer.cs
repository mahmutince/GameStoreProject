using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Concrete;

namespace GameStore.Entities
{
    public class Customer 
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TCNo { get; set; }
        public DateTime DateOfBirth { get; set; }

        
    }
}
