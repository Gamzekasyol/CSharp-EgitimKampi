﻿using CSahrpEgitimKampi301_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi_DataAccessLayer.Abstract
{
    public interface IOrderDal:IGenericDal<Order> // Order sınıfı için IGenericDal dan miras al.
    {
    }
}
