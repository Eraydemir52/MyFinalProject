﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _Products;
        public InMemoryProductDal()//constraccter
        {
            _Products = new List<Product> {
              new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
               new Product{ProductId=2,CategoryId=2,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=3,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                 new Product{ProductId=4,CategoryId=4,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                  new Product{ProductId=5,CategoryId=5,ProductName="Fare",UnitPrice=85,UnitsInStock=1}

            };
        }
        public void Add(Product product)
        {
            _Products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ -Language  Integrated Query
            //Lambda
            Product productToDelete = _Products.SingleOrDefault(P=>P.ProductId==product.ProductId);
            _Products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _Products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return  _Products.Where(p=>p.CategoryId==categoryId).ToList();
        }

        public void Update(Product product)
        {
            //gönnderdiğim ürün id'sine sahip listedek ürünü bul demek
            Product productToUpdate= _Products.SingleOrDefault(P => P.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
