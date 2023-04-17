﻿using System;
using Fiorello.Models;

namespace Fiorello.Services.Interfaces
{
	public interface IProductService
	{
		Task<Product> GetById(int? id);
		Task<IEnumerable<Product>> GetAll();
	}
}