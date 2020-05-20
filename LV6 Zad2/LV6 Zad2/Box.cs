﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LV6_Zad2
{
    class Box : IAbstractBoxCollection
    {
        private List<Product> products;
        public Box() { this.products = new List<Product>(); }
        public Box(List<Product> products)
        {
            this.products = new List<Product>(products.ToArray());
        }
        public void AddProduct(Product product) { this.products.Add(product); }
        public void RemoveProduct(Product product) { this.products.Remove(product); }

        public IAbstractBoxIterator GetIterator()
        {
            return new BoxIterator(this);
        }
        public Product this[int index] { get { return this.products[index]; } }

        public int Count { get { return this.products.Count; } }
    }
}
