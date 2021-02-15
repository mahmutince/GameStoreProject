using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Abstract;
using GameStore.Entities;

namespace GameStore.Concrete
{
    public class CheckManager : ICheckService
    {
        public bool Check(Customer customer)
        {
           
            if (customer.FirstName!=null && customer.LastName!=null && customer.TCNo!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
