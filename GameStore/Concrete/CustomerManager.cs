using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Abstract;
using GameStore.Entities;

namespace GameStore.Concrete
{
    public class CustomerManager : ICustomerService
    {
        CheckManager _checkManager;

        public CustomerManager(CheckManager checkManager)
        {
            _checkManager = checkManager;
        }

        public void Add(Customer customer)
        {
            if (_checkManager.Check(customer))
            {
                Console.WriteLine(customer.FirstName + " isimli kullanıcı eklendi.");

            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulanmadı.");
            }
            
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " isimli kullanıcı silindi.");

        }

        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " isimli kullanıcı güncellendi.");

        }
    }
}
