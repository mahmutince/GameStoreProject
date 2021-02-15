using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Entities;

namespace GameStore.Abstract
{
    public interface ICheckService
    {
        bool Check(Customer customer);
    }
}
