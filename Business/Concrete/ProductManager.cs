﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDao productDal;

        public ProductManager(IProductDao productDal)
        {
            this.productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}