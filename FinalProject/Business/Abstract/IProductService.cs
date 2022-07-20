﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
	public interface IProductService
	{
		List<Product> GetAll();
		List<Product> GetAllByCategoryId(int id);
		List<Product> GetByUnitPrice(decimal min, decimal max);
		void Add(Product product);
		void Update(Product product);
		void Delete(Product product);
		List<Product> GetAllByCategory(int categoryId);
	}
}