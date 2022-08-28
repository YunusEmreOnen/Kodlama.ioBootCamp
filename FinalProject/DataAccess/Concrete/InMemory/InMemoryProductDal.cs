﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>()
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStoct=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Tabak",UnitPrice=500,UnitsInStoct=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=150,UnitsInStoct=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStoct=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStoct=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete=null;

            //foreach (var p in _products)
            //{
            //    if(product.ProductId==p.ProductId)
            //        productToDelete = p;
            //}


            //LİNQ - Language Integrated Query and Lambda Expression 
            productToDelete = _products.FirstOrDefault(p=>p.ProductId==product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=>p.CategoryId==categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate;

            productToUpdate = _products.FirstOrDefault(p=>p.ProductId==product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStoct= product.UnitsInStoct;
            
        }
    }
}
