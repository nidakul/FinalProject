﻿using System;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IOrderService
	{
        List<Order> GetAll();
        Order GetById(int id);
    }
}

